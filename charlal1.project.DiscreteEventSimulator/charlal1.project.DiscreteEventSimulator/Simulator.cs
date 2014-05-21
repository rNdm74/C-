using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Simulator
    {
        private RandomNumberGenerator rGen;

        private Calender calender;
        private Event activeEvent;
        private List<Resource> resources;
        private Statistics simulationStatistics;

        private Queue ivr;        
        private Queue other;
        private Queue carStereo;

        public Simulator(Calender calender) 
        {
            this.activeEvent = calender.GetNextEvent();
            this.calender = calender;

            ivr = new Queue(EQueueType.IVR);
            other = new Queue(EQueueType.OTHER);
            carStereo = new Queue(EQueueType.CAR_STEREO);

            rGen = new RandomNumberGenerator();
        }

        public void RunSimulation() 
        {
            while (!(activeEvent is EndSimulationEvent))
            {
                activeEvent = calender.GetNextEvent();

                if (activeEvent is ArrivalEvent) 
                {
                    // Get active entity
                    Entity activeEntity = activeEvent.ActiveEntity;

                    // Assign enitiy its next event
                    activeEntity.NextEvent = EEventType.SWITCH_COMPLETE;

                    // Set entities start time at call centre
                    activeEntity.StartTime = activeEvent.EventTime;

                    // Get queue length
                    if (!ivr.IsFull())
                    {
                        // Calculate the next event time
                        DateTime nextEventTime = activeEntity.StartTime.AddMinutes(rGen.DelayAtIVR);
                        activeEntity.BeginWait = nextEventTime;

                        //Setup next event for active entity
                        calender.SpawnNewEvent(activeEntity);

                        // Entity is put in Switch Queue
                        ivr.Add(activeEntity); 
                    }

                    DateTime nextArrivalTime = Global.Clock.AddMinutes(rGen.TimeBetweenArrivals);

                    Entity nextEntity = calender.SpawnNewEntity();
                    nextEntity.StartTime = nextArrivalTime;

                    calender.SpawnNewEvent(nextEntity);
                }

                if (activeEvent is SwitchCompleteEvent)
                {
                    // Move to resource queue
                    calender.Worker(activeEvent);
                }        
        
                if(activeEvent is ProcessingCompleteEvent)
                {
                    // Resource has finished processing the Entitys request
                    calender.Worker(activeEvent);
                }                               
            }
        }
    }
}
