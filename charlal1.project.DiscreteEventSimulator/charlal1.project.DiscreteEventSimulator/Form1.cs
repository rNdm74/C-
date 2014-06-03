﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1.project.DiscreteEventSimulator
{
    public partial class Form1 : Form
    {
        Simulator simulator;
        
        Statistics statisticsSubject;
        IDisplay[] displayObservers;

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
                new Graphical(statisticsSubject, pGraphicalDisplay),
                new Text(statisticsSubject, dgvCalender, dgvOtherQueue, dgvCarStereoQueue),
                new Results(statisticsSubject, dgvStatistics, lbStatisticsResults)
            };


            //display = new Display(dgvCalender, dgvStatistics, dgvOtherQueue, dgvCarStereoQueue, lbStatisticsResults);

            simulator = new Simulator(dTPStartSimulationTime.Value, dTPEndSimulationTime.Value, statisticsSubject);
            simulator.RunSimulation();
        }
    }
}
