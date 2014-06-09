using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1.project.DiscreteEventSimulator
{
    class Simulator
    {
        private delegate void SetCallBack();

        private Statistics statistics;
        private Calender calender;
        private Event activeEvent;
        private ResourceManager resourceManager;        
        private EntityFactory entityFactory;
        private EventFactory eventFactory;
        private RandomNumberGenerator rGen;

        public Simulator(Statistics statistics) 
        {
            this.statistics = statistics;            

            calender = new Calender();
            resourceManager = new ResourceManager();
            rGen = new RandomNumberGenerator();
            entityFactory = new EntityFactory();
            eventFactory = new EventFactory();
            
            // Set global clock
            Global.CLOCK = Global.START_SIMULATION_TIME;

            // Add EndSim Event
            Event endSimulationEvent = eventFactory.Spawn(EEventType.END_SIMULATION, Global.END_SIMULATION_TIME, entityFactory.CreateEntity());
            calender.Add(endSimulationEvent);

            // Create First Arrival Event
            Entity firstCaller = entityFactory.CreateEntity();
            int nextArrivalTime = Global.CLOCK + rGen.TimeBetweenArrivals;
            Event firstArrivalEvent = eventFactory.Spawn(EEventType.ARRIVAL, nextArrivalTime, firstCaller);
            calender.Add(firstArrivalEvent);
        }

        public void RunSimulation() 
        {
            while (!(activeEvent is EndSimulationEvent))
            {                
                // Get next event from calender
                activeEvent = calender.GetNextEvent();

                // Update global clock
                Global.CLOCK = activeEvent.EventTime;

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
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);

                    // 3. Tidy up e.g. graphics update etc
                }        
        
                if(activeEvent is ProcessingCompleteEvent)
                {
                    // 1. Prepare info for the event

                    // 2. Tell event to execute
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);

                    // 3. Tidy up e.g. graphics update etc
                    
                }

                // Update simulation statistics
                statistics.UpdateLists(calender, resourceManager);
                statistics.NotifyDisplays();

                // Control the speed of the loop
                System.Threading.Thread.Sleep(Global.SIMULATION_SPEED);                
            }

            MessageBox.Show("The simulation completed successfully","Simulation Complete");
        }


    }
}
