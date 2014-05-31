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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simulator = new Simulator(dTPStartSimulationTime.Value, dTPEndSimulationTime.Value);
            simulator.RunSimulation();
        }
    }
}
