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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(t != null)
                t.Abort();
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

        private void InitializeGlobals() 
        {
            Global.Init();

            Global.ExportCSV = cbSaveFileDialog.Checked;
            
            // Simulation
            Global.StartSimulationTime = (int)nUpDownSimulationStartTime.Value;
            Global.EndSimulationTime = (int)nUpDownSimulationRunTime.Value;             
            Global.MaxResourcesType1 = (int)nUpDown_Max_Resources_Other.Value;
            Global.MaxResourcesType2 = (int)nUpDown_Max_Resources_Car_Stereo.Value;
            Global.MaxOnHold = (int)nUpDown_Max_On_Hold.Value;
            Global.ExcessiveWaitTime = (int)nUpDown_Excessive_Wait_Time.Value;
            Global.CallTypeProbability = (int)nUpDownCallTypeProbability.Value;

            // Delays
            Global.DelayArrival = (double)nUpDown_Delay_Arrival.Value;
            Global.DelaySwitch = (double)nUpDown_Delay_Switch.Value;
            Global.DelayProcessing = (double)nUpDown_Delay_Processing.Value;

            // Set simulation clock and total sytem run time
            Global.Clock = Global.StartSimulationTime;
            Global.SystemTime = Global.EndSimulationTime;

            // Setup the progressbar start value and max value 
            pbSimulation.Value = 0;
            pbSimulation.Maximum = Global.EndSimulationTime;
        }

        private void InitializeSimulation() 
        {
            statisticsSubject = new Statistics();

            displayObservers = new IDisplay[] 
            {
                new Graphical(statisticsSubject, this, pGraphicalDisplay),
                new Text(statisticsSubject, this,  dgvCalender, dgvOtherQueue, dgvCarStereoQueue),
                new Stats(statisticsSubject, this,  dgvStatistics, pbSimulation)
            };

            simulator = new Simulator(statisticsSubject);
        }

        private void StartSimulation() 
        {
            ThreadStart ts = new ThreadStart(simulator.RunSimulation);
            t = new Thread(ts);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void cbSaveFileDialog_CheckedChanged(object sender, EventArgs e)
        {
            Global.ExportCSV = cbSaveFileDialog.Checked;
        }
    }
}
