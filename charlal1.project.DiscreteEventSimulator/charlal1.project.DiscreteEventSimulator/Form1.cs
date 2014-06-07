using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
            dTPEndSimulationTime.Value = dTPEndSimulationTime.Value.AddHours(2);
            dTPEndSimulationTime.Refresh();

        }

        private void simulationStart_Click(object sender, EventArgs e)
        {
            initGlobals();

            statisticsSubject = new Statistics();
            displayObservers = new IDisplay[] 
            {
                new Graphical(statisticsSubject, this, pGraphicalDisplay),
                new Text(statisticsSubject, this,  dgvCalender, dgvOtherQueue, dgvCarStereoQueue),
                new Results(statisticsSubject, this,  dgvStatistics, lbStatisticsResults)
            };

            simulator = new Simulator(statisticsSubject);
            
            ThreadStart ts = new ThreadStart(simulator.RunSimulation);
            t = new Thread(ts);
            t.Start();
        }

        private void tbSimulationSpeed_Scroll(object sender, EventArgs e)
        {
            Global.SIMULATION_SPEED = tbSimulationSpeed.Value;
        }

        private void initGlobals() 
        {
            Global.START_SIMULATION_TIME = dTPStartSimulationTime.Value;
            Global.END_SIMULATION_TIME = dTPEndSimulationTime.Value;             
            Global.MAX_RESOURCES_OTHER = (int)nUpDown_Max_Resources_Other.Value;
            Global.MAX_RESOURCES_CAR_STEREO = (int)nUpDown_Max_Resources_Car_Stereo.Value;
            Global.MAX_ON_HOLD = (int)nUpDown_Max_On_Hold.Value;
            Global.EXCESSIVE_WAIT_TIME = (int)nUpDown_Excessive_Wait_Time.Value;
            Global.DELAY_ARRIVAL = (double)nUpDown_Delay_Arrival.Value;
            Global.DELAY_SWITCH = (double)nUpDown_Delay_Switch.Value;
            Global.DELAY_PROCESSING = (double)nUpDown_Delay_Processing.Value;

            
            

            // Set variables to 0
            Global.BusySignalCount = Global.CallCompletion = Global.CallCompletionOther = Global.CallCompletionCarStereo = Global.ExcessiveWaitCount = Global.ExcessiveWaitCountOther = Global.ExcessiveWaitCountCarStereo = Global.Iterations = Global.ResourcesUsed = 0;
            Global.AverageWaitingTime = Global.AverageSystemTime = Global.AverageNumberWaiting = Global.ResourceUtilization = Global.ResourseOtherWorkTime = Global.ResourseCarStereoWorkTime = Global.ResourseWorkTime = Global.SystemTime = 0;

            Global.SystemTime = Global.END_SIMULATION_TIME.Subtract(Global.START_SIMULATION_TIME).TotalSeconds;
        }
    }
}
