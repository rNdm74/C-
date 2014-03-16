using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        private IClock clock;
        private bool clockOn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbDigital.Checked)
            {
                clock.hide();
                clock = new Digital(lDigitalTime);
                clock.show();
            }
            else
            {
                clock.hide();
                clock = new Analogue(analogClock);
                clock.show();
            }

            clockOn = !clockOn;

            if (clockOn)
                clock.show();
            else
                clock.hide();
        }

        interface IClock
        {
            void show();
            void hide();
        }

        public class Digital : IClock
        {
            Label digitalClock;

            public Digital(Label digitalClock) 
            {
                this.digitalClock = digitalClock;
            }

            void IClock.show()
            {
                digitalClock.Visible = true;
            }

            void IClock.hide()
            {
                digitalClock.Visible = false;
            }
        }
        public class Analogue : IClock
        {
            AnalogClockControl.AnalogClock analogueClock;

            public Analogue(AnalogClockControl.AnalogClock analogueClock) 
            {
                this.analogueClock = analogueClock;
            }

            void IClock.show()
            {
                analogueClock.Visible = true;
            }

            void IClock.hide()
            {
                analogueClock.Visible = false;
            }
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;

            lDigitalTime.Text = date1.ToString("hh:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tClock.Enabled = true;

            if (rbDigital.Checked)
            {
                clock = new Digital(lDigitalTime);
            }
            else
            {
                clock = new Analogue(analogClock);
            }
        }

        private void rbDigital_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rButton = (RadioButton)sender;

            if(clockOn)
            {
                if (rButton.Checked)
                {
                    clock.hide();
                    clock = new Digital(lDigitalTime);
                    clock.show();
                }
                else
                {
                    clock.hide();
                    clock = new Analogue(analogClock);
                    clock.show();
                }
            }                      
        }
    }
}
