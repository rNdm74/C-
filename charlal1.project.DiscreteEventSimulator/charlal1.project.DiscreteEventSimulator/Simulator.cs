using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            Global.Clock = Global.StartSimulationTime;

            // Add EndSim Event
            Event endSimulationEvent = eventFactory.Spawn(EEventType.END_SIMULATION, Global.EndSimulationTime, entityFactory.CreateEntity());
            calender.Add(endSimulationEvent);

            // Create First Arrival Event
            Entity firstCaller = entityFactory.CreateEntity();
            int nextArrivalTime = Global.Clock + rGen.TimeBetweenArrivals;
            Event firstArrivalEvent = eventFactory.Spawn(EEventType.ARRIVAL, nextArrivalTime, firstCaller);
            calender.Add(firstArrivalEvent);
        }

        /// <summary>
        /// Run the simulation
        /// </summary>
        public void RunSimulation() 
        {
            while (!(activeEvent is EndSimulationEvent))
            {                
                // Get next event from calender
                activeEvent = calender.GetNextEvent();

                // Update global clock
                Global.Clock = activeEvent.EventTime;

                if (activeEvent is ArrivalEvent) 
                {
                    // Tell event to execute
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);
                }

                if (activeEvent is SwitchCompleteEvent)
                {
                    // Tell event to execute
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);
                }        
        
                if(activeEvent is ProcessingCompleteEvent)
                {
                    // Tell event to execute
                    activeEvent.Execute(calender, resourceManager, statistics, rGen, entityFactory, eventFactory);
                }

                // Update simulation statistics
                statistics.UpdateLists(calender, resourceManager);
                statistics.NotifyDisplays();

                // Control the speed of the loop
                System.Threading.Thread.Sleep(Global.SimulationSpeed);                
            }

            // Gives user feedback at the end of the simulation
            if(Global.ExportCSV)
                OpenSaveFileDialog();
            else
                MessageBox.Show("The simulation completed successfully", "Simulation Complete");
        }

        /// <summary>
        /// Show the SaveFileDialog
        /// </summary>
        private void OpenSaveFileDialog() 
        {
            Stream stream;
            StreamWriter file;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "simulator_statistics_" + DateTime.Now.ToString("hhmmss_ddMMyyyy");
            saveFileDialog.Title = "Export Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    file = new StreamWriter(stream);

                    // Write csv header
                    file.WriteLine(Constants.EXPORT_DATA_HEADER);

                    // Code to write the stream goes here
                    foreach (KeyValuePair<int, string> item in statistics.ExportCSVData)
                        file.WriteLine(item.Key + "," + item.Value);

                    file.Close();
                    stream.Close();
                }
            }
        }
    }
}
