using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    interface IEvent
    {
        void Execute();
    }

    class Event 
    {
        public Entity CurrentEntity  { get; set; }
        public String EventName     { get; set; }
        public DateTime EventTime   { get; set; }
    }
                    
    // Entities initial request
    class ArrivalEvent : Event, IEvent
    {
        private EntityFactory entityFactory;

        public ArrivalEvent()
        {
            this.EventName = Constants.ARRIVAL;
            this.entityFactory = new EntityFactory();
        }

        public void Execute()
        {
            // Assign entity its next event
            CurrentEntity.NextEvent = EEventType.SWITCH_COMPLETE;

            // Set entities start time at call centre
            CurrentEntity.StartTime = EventTime;

            // Calculate the next event time
            DateTime nextEventTime = CurrentEntity.StartTime.AddMinutes(rGen.DelayAtIVR);
            CurrentEntity.BeginWait = nextEventTime;
        }
    }

    // Completion of Entities request at switchboard
    class SwitchCompleteEvent : Event
    {    
        public SwitchCompleteEvent() 
        {
            this.EventName = Constants.IVR;
        }
    }
    
    // Entities request is being processed
    class ProcessingCompleteEvent : Event
    {
        public ProcessingCompleteEvent() 
        {
            this.EventName = Constants.OTHER;
        }
    }
    
    // End of simulation
    class EndSimulationEvent : Event
    {
        public EndSimulationEvent() 
        {
            this.EventName = Constants.END;
        }
    }
}
