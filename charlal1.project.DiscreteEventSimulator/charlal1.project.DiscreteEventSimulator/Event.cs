using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Event
    {
        public string Name          { get; set; }
        public Entity CurrentEntity { get; set; }
        public DateTime EventTime   { get; set; }
        public ECallType CallType   { get; set; }
        public DateTime StartTime   { get; set; }
        public DateTime EndTime     { get; set; }
    }
    
    // Entities initial request
    class ArrivalEvent : Event
    {
        public ArrivalEvent(DateTime EventTime) 
        {
            this.EventTime = EventTime;
        }        
    }

    // Completion of Entities request at switchboard
    class SwitchCompleteEvent : Event
    {
        // Entity has specified call type
    }

    // Entity is in a queue
    class QueueEvent : Event
    {
        // Entity has been put in a queue
    }

    // Entities request is being processed
    class ProcessingCompleteEvent : Event
    {
        // Entity has finished being processed        
    }

    // Entities request finished
    class FinishedEvent : Event
    {
        // Spawn new Entity in calender;
    }

    // End of simulation
    class EndSimulationEvent : Event
    {
        public EndSimulationEvent(DateTime EventTime) 
        {
            this.EventTime = EventTime;
        }        
    }
}
