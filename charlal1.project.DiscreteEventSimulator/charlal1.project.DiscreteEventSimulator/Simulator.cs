using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Simulator
    {
        private Calender calender;
        private object activeEvent;

        public Simulator(Calender calender) 
        {
            this.activeEvent = calender.GetNextEvent();
            this.calender = calender;            
        }

        public void RunSimulation() 
        {
            while (!(activeEvent is EndSimulationEvent))
            {
                if (activeEvent is ArrivalEvent) 
                {
                    // Call is placed
                }
                if (activeEvent is SwitchCompleteEvent)
                {
                    // Move to queue
                }
                if (activeEvent is QueueEvent) 
                {
                    // Wait till Resource is free
                }
                if(activeEvent is ProcessingCompleteEvent)
                {
                    // Resource has finished processing the Entitys request
                }
                if (activeEvent is FinishedEvent)
                {
                    // Free resource for next entity in queue
                }

                activeEvent = calender.GetNextEvent();
            }
        }
    }
}
