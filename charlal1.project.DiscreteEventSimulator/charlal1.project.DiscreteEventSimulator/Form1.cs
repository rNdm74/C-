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
            statisticsSubject = new Statistics();
            displayObservers = new IDisplay[] 
            {
                new Graphical(statisticsSubject, this, pGraphicalDisplay),
                new Text(statisticsSubject, this,  dgvCalender, dgvOtherQueue, dgvCarStereoQueue),
                new Results(statisticsSubject, this,  dgvStatistics, lbStatisticsResults)
            };

            simulator = new Simulator(dTPStartSimulationTime.Value, dTPEndSimulationTime.Value, statisticsSubject);
            
            ThreadStart ts = new ThreadStart(simulator.RunSimulation);
            t = new Thread(ts);
            t.Start();
        }

        private void tbSimulationSpeed_Scroll(object sender, EventArgs e)
        {
            Global.SimulationSpeed = tbSimulationSpeed.Value;
        }
    }
}
