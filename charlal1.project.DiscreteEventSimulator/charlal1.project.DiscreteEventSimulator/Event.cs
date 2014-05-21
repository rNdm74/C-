using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    interface IEvent
    {
        void Process();
    }

    class Event 
    {
        public Entity ActiveEntity  { get; set; }
        public String EventName     { get; set; }
        public DateTime EventTime   { get; set; }
    }
                    
    // Entities initial request
    class ArrivalEvent : Event
    {
        public ArrivalEvent()
        {
            this.EventName = Constants.ARRIVAL;
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
