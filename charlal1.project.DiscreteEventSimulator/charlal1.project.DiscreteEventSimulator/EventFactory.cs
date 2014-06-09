using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class EventFactory
    {
        // Will build all events in simulaiton
        // Type, Datetime , Entity 

        public Event Spawn(EEventType eventType, int eventTime, Entity currentEntity)
        {
            Event newEvent = null;

            switch (eventType)
            {
                case EEventType.ARRIVAL:
                    newEvent = new ArrivalEvent(eventTime, currentEntity);
                    break;
                case EEventType.SWITCH_COMPLETE:
                    newEvent = new SwitchCompleteEvent(eventTime, currentEntity);
                    break;
                case EEventType.PROCESSING_COMPLETE:
                    newEvent = new ProcessingCompleteEvent(eventTime, currentEntity);
                    break;
                case EEventType.END_SIMULATION:
                    newEvent = new EndSimulationEvent(eventTime, currentEntity);
                    break;
            }

            return newEvent;
        }        
    }
}
