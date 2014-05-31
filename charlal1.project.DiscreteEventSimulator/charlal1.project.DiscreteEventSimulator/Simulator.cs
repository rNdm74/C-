using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Simulator
    {
        

        private Calender calender;
        private Event activeEvent;
        private ResourceManager resourceManager;
        private Statistics statistics;
        private EntityFactory entityFactory;
        private EventFactory eventFactory;
        private RandomNumberGenerator rGen;

        public Simulator(DateTime SimulationStartDateTime, DateTime SimulationEndDateTime) 
        {
            calender = new Calender();            
            statistics = new Statistics();
            entityFactory = new EntityFactory();
            eventFactory = new EventFactory();
            rGen = new RandomNumberGenerator();

            Global.Clock = SimulationStartDateTime;
            Event endSimulationEvent = eventFactory.Spawn(EEventType.END_SIMULATION, SimulationEndDateTime, null);

            Entity firstCaller = entityFactory.CreateEntity();
            DateTime nextArrivalTime = Global.Clock.AddMinutes(rGen.TimeBetweenArrivals);
            Event firstArrivalEvent = eventFactory.Spawn(EEventType.ARRIVAL, nextArrivalTime, firstCaller);
            calender.Add(endSimulationEvent);
            
            
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
                //Entity activeEntity = activeEvent.CurrentEntity;

                if (activeEvent is ArrivalEvent) 
                {
                    // 1. Prepare info for the event

                    // 2. Tell event to execute
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);

                    // 3. Tidy up e.g. graphics update etc                    
                }

                if (activeEvent is SwitchCompleteEvent)
                {
                    // 1. Prepare info for the event

                    // 2. Tell event to execute
                    //    give resourcemanager
                    //    activeEvent.Execute();
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);

                    // 3. Tidy up e.g. graphics update etc
                }        
        
                if(activeEvent is ProcessingCompleteEvent)
                {
                    // 1. Prepare info for the event

                    // 2. Tell event to execute
                    //    give resourcemanager
                    //    activeEvent.Execute();
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);

                    // 3. Tidy up e.g. graphics update etc
                }                               
            }
        }
    }
}
