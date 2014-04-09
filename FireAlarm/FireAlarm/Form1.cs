using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        private FireMonitorSubject fireMonitorSubject;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bFireAlarm_Click(object sender, EventArgs e)
        {
            string catagory = "";

            if (rbMinor.Checked)
                catagory = "Minor";
            if (rbSerious.Checked)
                catagory = "Serious";
            if (rbInferno.Checked)
                catagory = "Inferno";

            fireMonitorSubject.OnFireEvent(catagory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fireMonitorSubject = new FireMonitorSubject();

            InstructionsFireObserver instructionsFireObserver = new InstructionsFireObserver(fireMonitorSubject);
            AlarmBellFireObserver alarmBellFireObserver = new AlarmBellFireObserver(fireMonitorSubject);
        }
    }
}
