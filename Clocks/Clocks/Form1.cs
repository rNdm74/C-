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
        /// <summary>
        /// Nested classes, issues in visual studio creating new classes
        /// Hopefully this is not a problem
        /// </summary>
        private ClockManager mClock;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mClock = new ClockManager(tClock, lDigitalTime, analogClock);
        }
        private void tClock_Tick(object sender, EventArgs e)
        {
            lDigitalTime.Text = mClock.UpdateTime();
        }
        private void rbDigital_CheckedChanged(object sender, EventArgs e)
        {
            mClock.UpdateClock(sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = mClock.DisplayClock(rbDigital);
        }

        /// <summary>
        /// Main Clock Manager 
        /// NOTE: To prevent the form knowing to much about the clock
        /// </summary>
        class ClockManager
        {
            private IClock clock;
            private bool clockOn;
            private Label lDigitalTime;
            private AnalogClockControl.AnalogClock analogClock;

            public ClockManager(Timer tClock, Label lDigitalTime, AnalogClockControl.AnalogClock analogClock)
            {
                this.lDigitalTime = lDigitalTime;
                this.analogClock = analogClock;

                // Start timer for updating time
                tClock.Enabled = true;

                // Default new clock digital
                clock = new Digital(lDigitalTime);
            }

            public string DisplayClock(RadioButton rbDigital)
            {
                // Update clock
                updateClock(rbDigital);

                // Toggle clock display
                clockOn = !clockOn;

                // Display clock
                if (clockOn)
                    clock.show();
                else
                    clock.hide();

                // Returns if on or off
                return (clockOn) ? "Off" : "On";
            }

            public void UpdateClock(object sender)
            {
                // Show clock on form
                if (clockOn)
                    updateClock(sender);
            }

            public string UpdateTime()
            {
                DateTime date = DateTime.Now;
                // Displays just the time no date
                return date.ToString("hh:mm:ss tt");
            }

            private void updateClock(object sender)
            {
                // Make the radio button
                RadioButton rButton = (RadioButton)sender;

                // Display as digital or analogue
                if (rButton.Checked)
                    update(new Digital(lDigitalTime));
                else
                    update(new Analogue(analogClock));
            }

            private void update(IClock newClock)
            {
                // Hides the currently displayed clock
                clock.hide();
                // Changes to new clock
                clock = newClock;
                // Displays new clock
                clock.show();
            }
        }

        /// <summary>
        /// Interfaces
        /// </summary>
        interface IClock
        {
            void show();
            void hide();
        }
        class Digital : IClock
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
        class Analogue : IClock
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
    }
}
