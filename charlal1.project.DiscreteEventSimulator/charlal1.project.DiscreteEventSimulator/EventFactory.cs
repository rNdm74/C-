using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class EventFactory
    {
        // Will build all events in simulaiton
        
        public Event Spawn(EEventType eventType) // datetime , entity 
        {
            Event newEvent = null;

            switch (eventType)
            {
                case EEventType.ARRIVAL:
                    newEvent = new ArrivalEvent();
                    break;
                case EEventType.SWITCH_COMPLETE:
                    newEvent = new SwitchCompleteEvent();
                    break;
                case EEventType.PROCESSING_COMPLETE:
                    newEvent = new ProcessingCompleteEvent();
                    break;
                case EEventType.END_SIMULATION:
                    newEvent = new EndSimulationEvent();
                    break;
            }

            return newEvent;
        }        
    }
}
