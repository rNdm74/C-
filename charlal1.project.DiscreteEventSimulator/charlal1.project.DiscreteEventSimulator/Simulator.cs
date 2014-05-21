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
                    // Update global clock
                    Global.Clock = activeEvent.EventTime;

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

                    // Calculate next arrival time 
                    DateTime nextArrivalTime = Global.Clock.AddMinutes(rGen.TimeBetweenArrivals);

                    // Create entity
                    Entity nextEntity = calender.SpawnNewEntity();
                    nextEntity.NextEvent = EEventType.ARRIVAL;
                    nextEntity.StartTime = nextArrivalTime;

                    // Setup next event for entity
                    calender.SpawnNewEvent(nextEntity);
                }

                if (activeEvent is SwitchCompleteEvent)
                {
                    // Update Clock
                    // Set active entity
                    // Set active entites call type

                    // Check to see if rep is available 
                    // if available rep process call
                    // and spawn next event
                    // else add entity to rep queue and set begin wait time
                    
                }        
        
                if(activeEvent is ProcessingCompleteEvent)
                {
                    
                    // Update clock
                    // Update statistics of enitiy leaving system
                    // Rep is now free, look at queue
                    // if empty set busy flag to false
                    // else 
                    // remove entity at head of queue
                    // compute its process time
                    // add a new complete service event to the calender at new time with active entity
                }                               
            }
        }
    }
}
