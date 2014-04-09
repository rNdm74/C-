using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metronome
{
    public partial class Form1 : Form
    {
        private Metronome mainMetronome;
        private Beeper mainBeeper;
        private Counter mainCounter;
        private TimeDisplay mainTimeDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Note the Form being passed to the metronome…It comes in handy
            mainMetronome = new Metronome(1000, this);

            mainBeeper = new Beeper(mainMetronome, "blip1.wav");
            mainCounter = new Counter(mainMetronome, nUpDown);
            mainTimeDisplay = new TimeDisplay(mainMetronome, lTime);
        }

        private void bStartMetronome_Click(object sender, EventArgs e)
        {
            int currInterval = Convert.ToInt16(tbInterval.Text);
            mainMetronome.Interval = currInterval;
            mainMetronome.Start();
        }
    }
}
