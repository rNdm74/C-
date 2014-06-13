using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace charlal1.project.DiscreteEventSimulator
{
    public partial class Form1 : Form
    {
        private Simulator simulator;
        private Statistics statisticsSubject;
        private IDisplay[] displayObservers;
        private Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeGlobals();
            InitializeSimulation();
        }

        #region Windows Form Handlers

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(t != null)
                t.Abort();
        }

        private void cbSaveFileDialog_CheckedChanged(object sender, EventArgs e)
        {
            Global.ExportCSV = cbSaveFileDialog.Checked;
        }

        private void bResetToDefaults_Click(object sender, EventArgs e)
        {
            nUpDown_Other_Max_Resources.Value = Constants.OTHER_MAX_RESOURCES;
            nUpDown_Car_Stereo_Max_Resources.Value = Constants.CAR_STEREO_MAX_RESOURCES;
            nUpDown_Max_On_Hold.Value = Constants.MAX_ON_HOLD;
            nUpDown_Excessive_Wait_Time.Value = (decimal)Constants.EXCESSIVE_WAIT_TIME;
            nUpDown_Arrival_Delay.Value = (decimal)Constants.ARRIVAL_DELAY;
            nUpDown_Switch_Delay.Value = (decimal)Constants.SWITCH_DELAY;
            nUpDown_Processing_Delay.Value = (decimal)Constants.PROCESSING_DELAY;
            nUpDown_CallType_Probability.Value = Constants.CALL_TYPE_PROBABILITY;
        }

        private void tbSimulationSpeed_Scroll(object sender, EventArgs e)
        {
            Global.SimulationSpeed = tbSimulationSpeed.Value;
        }

        private void simulationStart_Click(object sender, EventArgs e)
        {
            if (t != null)
                t.Abort();

            InitializeGlobals();
            InitializeSimulation();
            StartSimulation();
        }
        
        #endregion

        /// <summary>
        /// Setup all the global variables for the simulation
        /// </summary>
        private void InitializeGlobals() 
        {
            Global.Init();

            Global.ExportCSV = cbSaveFileDialog.Checked;
            
            // Simulation
            Global.StartSimulationTime = (int)nUpDownSimulationStartTime.Value;
            Global.EndSimulationTime = (int)nUpDownSimulationRunTime.Value;             
            Global.MaxResourcesType1 = (int)nUpDown_Other_Max_Resources.Value;
            Global.MaxResourcesType2 = (int)nUpDown_Car_Stereo_Max_Resources.Value;
            Global.MaxOnHold = (int)nUpDown_Max_On_Hold.Value;
            Global.ExcessiveWaitTime = (int)nUpDown_Excessive_Wait_Time.Value;
            Global.CallTypeProbability = (int)nUpDown_CallType_Probability.Value;

            // Delays
            Global.DelayArrival = (double)nUpDown_Arrival_Delay.Value;
            Global.DelaySwitch = (double)nUpDown_Switch_Delay.Value;
            Global.DelayProcessing = (double)nUpDown_Processing_Delay.Value;

            // Set simulation clock and total sytem run time
            Global.Clock = Global.StartSimulationTime;
            Global.SystemTime = Global.EndSimulationTime;

            // Setup the progressbar start value and max value 
            pbSimulation.Value = 0;
            pbSimulation.Maximum = Global.EndSimulationTime;
        }

        /// <summary>
        /// Create the simulation
        /// </summary>
        private void InitializeSimulation() 
        {
            // Setup subject
            statisticsSubject = new Statistics();

            // Setup observers
            displayObservers = new IDisplay[] 
            {
                new Graphical(statisticsSubject, this, pGraphicalDisplay),
                new Text(statisticsSubject, this,  dgvCalender, dgvOtherQueue, dgvCarStereoQueue),
                new Stats(statisticsSubject, this,  dgvStatistics, pbSimulation)
            };

            // Setup simulator
            simulator = new Simulator(statisticsSubject);
        }

        /// <summary>
        /// Start, this will launch in a seperate thread 
        /// </summary>
        private void StartSimulation() 
        {
            // Launch simulation in its own thread
            ThreadStart ts = new ThreadStart(simulator.RunSimulation);
            t = new Thread(ts);
            t.SetApartmentState(ApartmentState.STA); // for save file dialog
            t.Start();
        }
    }
}
