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
            Global.SIMULATION_SPEED = tbSimulationSpeed.Value;
        }

        private void simulationStart_Click(object sender, EventArgs e)
        {
            InitializeGlobals();
            InitializeSimulation();
            StartSimulation();
        }

        private void InitializeGlobals() 
        {
            
            
            Global.START_SIMULATION_TIME = (int) nUpDownSimulationStartTime.Value;
            Global.END_SIMULATION_TIME = (int) nUpDownSimulationRunTime.Value;             
            Global.MAX_RESOURCES_OTHER = (int) nUpDown_Max_Resources_Other.Value;
            Global.MAX_RESOURCES_CAR_STEREO = (int)nUpDown_Max_Resources_Car_Stereo.Value;
            Global.MAX_ON_HOLD = (int)nUpDown_Max_On_Hold.Value;
            Global.EXCESSIVE_WAIT_TIME = (int)nUpDown_Excessive_Wait_Time.Value;
            Global.DELAY_ARRIVAL = (double)nUpDown_Delay_Arrival.Value;
            Global.DELAY_SWITCH = (double)nUpDown_Delay_Switch.Value;
            Global.DELAY_PROCESSING = (double)nUpDown_Delay_Processing.Value;

            // Set variables to 0
            Global.BusySignalCount = Global.CallCompletion = Global.CallCompletionOther = Global.CallCompletionCarStereo = Global.ExcessiveWaitCount = Global.ExcessiveWaitCountOther = Global.ExcessiveWaitCountCarStereo = Global.Iterations = Global.ResourcesUsed = 0;
            Global.AverageWaitingTime = Global.AverageSystemTime = Global.AverageNumberWaiting = Global.ResourceUtilization = Global.ResourseOtherWorkTime = Global.ResourseCarStereoWorkTime = Global.ResourseWorkTime = Global.SystemTime = 0;

            Global.CLOCK = Global.START_SIMULATION_TIME;
            Global.SystemTime = Global.END_SIMULATION_TIME;

            pbSimulation.Value = 0;
            pbSimulation.Maximum = Global.END_SIMULATION_TIME;
        }

        private void InitializeSimulation() 
        {
            statisticsSubject = new Statistics();

            displayObservers = new IDisplay[] 
            {
                new Graphical(statisticsSubject, this, pGraphicalDisplay),
                new Text(statisticsSubject, this,  dgvCalender, dgvOtherQueue, dgvCarStereoQueue),
                new Results(statisticsSubject, this,  dgvStatistics, pbSimulation)
            };

            simulator = new Simulator(statisticsSubject);
        }

        private void StartSimulation() 
        {
            ThreadStart ts = new ThreadStart(simulator.RunSimulation);
            t = new Thread(ts);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            StreamWriter file;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    file = new StreamWriter(myStream);
                    string header =
                            "Iterations," +
                            "Busy Signal," +
                            "Call Completion," +
                            "Call Completion Other," +
                            "Call Completion Car Stereo," +
                            "Excessive Wait Count," +
                            "Excessive Wait Count Other," +
                            "Excessive Wait Count Car Stereo," +
                            "Resource Utilization," +
                            "Resource Other Utilization," +
                            "Resource Car Stereo Utilization," +
                            "Resourse Other Work Time," +
                            "Resourse Car Stereo Work Time," +
                            "Resourse Work Time," +
                            "System Time," +
                            "Average Number Waiting," +
                            "Average Waiting Time," +
                            "Average Number Waiting Other," +
                            "Average Number Waiting Car Stereo," +
                            "Average System Time";


                    file.WriteLine(header);

                    // Code to write the stream goes here.
                    foreach (KeyValuePair<int, string> item in statisticsSubject.CsvData)
                    {
                        

                        file.WriteLine(item.Key + "," + item.Value);
                    }

                    file.Close();
                    myStream.Close();
                }
            }
        }
    }
}
