using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    interface IEvent
    {
        void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory);
    }

    abstract class Event : IEvent
    {
        public Entity CurrentEntity     { get; set; }
        public EEventType EventType     { get; set; }
        public int EventTime            { get; set; }
        public double ProcessingTime    { get; set; }
        
        public Event(int eventTime, Entity currentEntity) 
        {
            this.EventTime = eventTime;
            this.CurrentEntity = currentEntity;
        }

        /// <summary>
        /// Method to execute all event procedures
        /// </summary>
        public abstract void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory);

        /// <summary>
        /// Returns a string list of all event data
        /// </summary>
        public string[] ToString() 
        {
            // Get timespan
            TimeSpan et = TimeSpan.FromSeconds(EventTime);
            // Calculate hours
            int etHours = et.Hours + (Global.StartSimulationTime / Constants.DATE_TIME_FACTOR);

            // Setup string[] for display
            string[] entityToString = CurrentEntity.ToString();
            entityToString[1] = EventType.ToString();
            entityToString[2] = string.Format("{0:D1}:{1:D2}:{2:D2}", etHours, et.Minutes, et.Seconds);

            // return data string array
            return entityToString;
        }
    }
      
    class ArrivalEvent : Event
    {
        /// <summary>
        /// Entities initial request
        /// </summary>
        /// <param name="eventTime">The time the event occurs</param>
        /// <param name="currentEntity"> Entity associated with the eventd</param>
        public ArrivalEvent(int eventTime, Entity currentEntity)
            : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.ARRIVAL;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory)
        {
            // Set entities start time at call centre
            CurrentEntity.StartTime = EventTime;

            // Total of the two product queues
            if (resourceManager.IsSpaceInQueues)
            {
                // Set active entites call type
                CurrentEntity.CallType = rGen.GetCallType;

                // Calculate the next event time
                int nextEventTime = CurrentEntity.StartTime + rGen.DelayAtSwitch;

                // Setup next event for active entity switch complete event
                Event processingCompleteEvent = eventFactory.Spawn(EEventType.SWITCH_COMPLETE, nextEventTime, CurrentEntity);
                
                // Add to calender
                calender.Add(processingCompleteEvent);
            }
            else
            {
                // Entity hangs up at the switch
                Global.BusySignalCount++;
            }

            // Calculate next arrival time 
            int nextArrivalTime = EventTime + rGen.TimeBetweenArrivals;

            // Create entity
            Entity nextEntity = entitiyFactory.CreateEntity();

            // Setup next event for entity
            Event nextEvent = eventFactory.Spawn(EEventType.ARRIVAL, nextArrivalTime, nextEntity);

            // Add to the calender
            calender.Add(nextEvent);
        }
    }

    class SwitchCompleteEvent : Event
    {
        /// <summary>
        /// Completion of Entities request at switchboard
        /// </summary>
        /// <param name="eventTime">The time the event occurs</param>
        /// <param name="currentEntity"> Entity associated with the eventd</param>
        public SwitchCompleteEvent(int eventTime, Entity currentEntity)
            : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.SWITCH_COMPLETE;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory) // ResourceManager
        {   
            // Check to see if rep is available 
            Resource resource = resourceManager.NextAvailableResource(CurrentEntity.CallType);

            // if available rep 
            if (resource != null)
            {
                // Resource is now busy
                resource.IsFree = false;

                // Entity is assigned a resource
                CurrentEntity.AssignResource = resource;

                // Set the time the enitity starts being processed
                CurrentEntity.StartProcessingTime = Global.Clock;

                // Compute its process time
                int nextEventTime = EventTime + rGen.NextEventTime(CurrentEntity.CallType);

                // Spawn Processing Complete Event
                Event nextEvent = eventFactory.Spawn(EEventType.PROCESSING_COMPLETE, nextEventTime, CurrentEntity);

                // Add to calender
                calender.Add(nextEvent);
            }
            else 
            {
                // Set begin wait time
                CurrentEntity.BeginWait = EventTime;
                
                // Add entity to resource queue
                resourceManager.AddToQueue(CurrentEntity);
            }
        }
    }
     
    class ProcessingCompleteEvent : Event
    {
        /// <summary>
        /// Entities request is being processed
        /// </summary>
        /// <param name="eventTime">The time the event occurs</param>
        /// <param name="currentEntity"> Entity associated with the eventd</param>
        public ProcessingCompleteEvent(int eventTime, Entity currentEntity)
            : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.PROCESSING_COMPLETE;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory) 
        {
            // Set entities time they finish in the system
            CurrentEntity.EndTime = EventTime;
            
            // Update statistics of enitiy leaving system
            statistics.UpdateEntityStatistics(CurrentEntity);            
                        
            // (active entity Rep) is now free, look at queue
            Resource resource = CurrentEntity.AssignResource;
            
            // if Queue is empty 
            if (resourceManager.IsQueueEmpty(resource.CallType))
            {
                // Set busy flag to false
                resource.IsFree = true;
            }
            else
            {                
                // Remove entity at head of queue
                Entity nextEntityInQueue = resourceManager.GetFirstInQueue(resource.CallType);

                // Set the time the enitity starts being processed
                nextEntityInQueue.StartProcessingTime = Global.Clock;

                // Resource is now busy
                resource.IsFree = false;

                // Assign the entity a resource
                nextEntityInQueue.AssignResource = resource;

                // Compute its process time
                int nextEventTime = EventTime + rGen.NextEventTime(resource.CallType);

                // Spawn next event
                Event nextEvent = eventFactory.Spawn(EEventType.PROCESSING_COMPLETE, nextEventTime, nextEntityInQueue);

                // Add to calender
                calender.Add(nextEvent);
            }
        }
    }
    
    class EndSimulationEvent : Event
    {
        /// <summary>
        /// End of simulation
        /// </summary>
        /// <param name="eventTime">The time the event occurs</param>
        /// <param name="currentEntity"> Entity associated with the eventd</param>
        public EndSimulationEvent(int eventTime, Entity currentEntity)
            : base(eventTime, currentEntity)
        {
            this.EventType = EEventType.END_SIMULATION;
        }

        public override void Execute(Calender calender, ResourceManager resourceManager, Statistics statistics, RandomNumberGenerator rGen, EntityFactory entitiyFactory, EventFactory eventFactory)
        {
        }
    }
}
