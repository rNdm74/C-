using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    interface IEvent
    {
        void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory);
        void GetDataReady();
    }

    class Event: IEvent
    {
        public Entity CurrentEntity  { get; set; }
        public EEventType EventType     { get; set; }
        public DateTime EventTime   { get; set; }

        // give everything  pass in in event constructor
        protected Calender calender;
        protected ResourceManager resourceManager;
        protected Statistics statistics;
        protected RandomNumberGenerator rGen;
        protected EntityFactory entitiyFactory;
        protected EventFactory eventFactory;

        // make constructor
        public Event(DateTime eventTime, Entity currentEntity) 
        {
            this.EventTime = eventTime;
            this.CurrentEntity = currentEntity;
        }
        
        public virtual void GetDataReady() {}

        public virtual void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory)
        {
            
        }
    }
                    
    // Entities initial request
    class ArrivalEvent : Event
    {
        public ArrivalEvent(DateTime eventTime, Entity currentEntity) : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.ARRIVAL;
        }
        
        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory)
        {
            // Assign entity its next event
            CurrentEntity.NextEvent = EEventType.SWITCH_COMPLETE;

            // Set entities start time at call centre
            CurrentEntity.StartTime = EventTime;

            // Calculate the next event time
            DateTime nextEventTime = CurrentEntity.StartTime.AddMinutes(rGen.DelayAtIVR);

            // Get queue length
            // Total of the two product queues
            if (resourceManager.IsSpaceInQueues())
            {
                //Setup next event for active entity switch complete event
                Event processingCompleteEvent = eventFactory.Spawn(EEventType.PROCESSING_COMPLETE, nextEventTime, CurrentEntity);
                
                // Add to calender
                calender.Add(processingCompleteEvent);
            }

            // Calculate next arrival time 
            DateTime nextArrivalTime = Global.Clock.AddMinutes(rGen.TimeBetweenArrivals);

            // Create entity
            Entity nextEntity = entitiyFactory.CreateEntity();

            // Setup next event for entity
            Event nextEvent = eventFactory.Spawn(EEventType.ARRIVAL, nextArrivalTime, nextEntity);

            // Add to the calender
            calender.Add(nextEvent);
        }
    }

    // Completion of Entities request at switchboard
    class SwitchCompleteEvent : Event
    {
        public SwitchCompleteEvent(DateTime eventTime, Entity currentEntity) : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.SWITCH_COMPLETE;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory) // ResourceManager
        {
            // Set active entites call type
            CurrentEntity.CallType = (rGen.Roll() <= Constants.CALL_PROBABILITY) ? ECallType.CAR_STEREO : ECallType.OTHER;

            // Check to see if rep is available 
            Resource resource = resourceManager.NextAvailableResource();

            // if available rep 
            if (resource != null)
            {
                // entity hold rep
                CurrentEntity.AssignResource = resource;

                // and spawn next event
                DateTime nextEventTime = CurrentEntity.StartTime.AddMinutes((CurrentEntity.CallType == ECallType.CAR_STEREO) ? rGen.DelayCarStereo() : rGen.DelayOther());
                Event nextEvent = eventFactory.Spawn(EEventType.PROCESSING_COMPLETE, nextEventTime, CurrentEntity);

                // Add to calender
                calender.Add(nextEvent);
            }
            else 
            {
                // Set begin wait time
                CurrentEntity.BeginWait = Global.Clock;
                
                // Add entity to rep queue
                resourceManager.AddToQueue(CurrentEntity);
            }
        }
    }
    
    // Entities request is being processed
    class ProcessingCompleteEvent : Event
    {
        public ProcessingCompleteEvent(DateTime eventTime, Entity currentEntity) : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.PROCESSING_COMPLETE;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory) 
        {
            // Update statistics of enitiy leaving system

            // (active entity Rep) is now free, look at queue
            Resource resource = CurrentEntity.AssignResource;

            // if Queue is empty 
            if (resourceManager.IsQueueEmpty(CurrentEntity.CallType))
            {
                // Set busy flag to false
                resource.IsFree = false;
            }
            else
            {
                // Remove entity at head of queue
                resourceManager.GetNextEntityInQueue(resource.CallType);

                // compute its process time
                DateTime nextEventTime = CurrentEntity.StartTime.AddMinutes((CurrentEntity.CallType == ECallType.CAR_STEREO) ? rGen.DelayCarStereo() : rGen.DelayOther());

                // Spawn next event
                Event nextEvent = eventFactory.Spawn(EEventType.PROCESSING_COMPLETE, nextEventTime, CurrentEntity);

                // Add to calender
                calender.Add(nextEvent);
            }
        }
    }
    
    // End of simulation
    class EndSimulationEvent : Event
    {
        public EndSimulationEvent(DateTime eventTime, Entity currentEntity) : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.END_SIMULATION;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory)
        { 
        }
    }
}
