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

        private Queue ivrQueue;        
        private Queue otherQueue;
        private Queue carStereoQueue;

        public Simulator(Calender calender) 
        {
            this.activeEvent = calender.GetNextEvent();
            this.calender = calender;

            ivrQueue = new Queue(EQueueType.IVR);
            otherQueue = new Queue(EQueueType.OTHER);
            carStereoQueue = new Queue(EQueueType.CAR_STEREO);

            rGen = new RandomNumberGenerator();
        }

        public void RunSimulation() 
        {
            while (!(activeEvent is EndSimulationEvent))
            {
                // Get next event from calender
                activeEvent = calender.GetNextEvent();

                // Update global clock
                Global.Clock = activeEvent.EventTime;

                // Get active entity
                Entity activeEntity = activeEvent.CurrentEntity;

                if (activeEvent is ArrivalEvent) 
                {
                    //
                    //activeEvent.Execute();

                    // Assign entity its next event
                    activeEntity.NextEvent = EEventType.SWITCH_COMPLETE;

                    // Set entities start time at call centre
                    activeEntity.StartTime = activeEvent.EventTime;

                    // Calculate the next event time
                    DateTime nextEventTime = activeEntity.StartTime.AddMinutes(rGen.DelayAtIVR);
                    activeEntity.NextEventTime = nextEventTime;

                    // Get queue length
                    // Total of the two product queues
                    if (true)
                    {
                        //Setup next event for active entity switch complete event
                        calender.SpawnNewEvent(activeEvent.CurrentEntity);

                        //
                      
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
                    // execute


                    // Update Clock
                  
                    //give resourcemanager
                    // Set active entites call type

                    // Check to see if rep is available 
                    // if available rep 
                    // entity hold rep
                    // and spawn next event
                    // else add entity to rep queue and set begin wait time
                    
                }        
        
                if(activeEvent is ProcessingCompleteEvent)
                {
                    // Update clock

                    // Update statistics of enitiy leaving system

                    // (active entity Rep) is now free, look at queue

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
