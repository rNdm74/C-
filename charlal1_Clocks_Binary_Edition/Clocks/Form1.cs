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
            mClock = new ClockManager(tClock, lDigitalTime, analogClock, pBinary);
        }
        private void tClock_Tick(object sender, EventArgs e)
        {
            mClock.UpdateTime();
        }
        private void rbDigital_CheckedChanged(object sender, EventArgs e)
        {
            mClock.UpdateClock(sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton rb = null;

            if (rbDigital.Checked)
                rb = rbDigital;
            if (rbAnalogue.Checked)
                rb = rbAnalogue;
            if (rbBinary.Checked)
                rb = rbBinary;

            button1.Text = mClock.DisplayClock(rb);
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
            private Panel pBinary;

            public ClockManager(Timer tClock, Label lDigitalTime, AnalogClockControl.AnalogClock analogClock, Panel pBinary)
            {
                this.lDigitalTime = lDigitalTime;
                this.analogClock = analogClock;
                this.pBinary = pBinary;

                // Start timer for updating time
                tClock.Enabled = true;

                // Default new clock digital
                clock = new Digital(lDigitalTime);
            }

            public string DisplayClock(RadioButton checkedRadioButton)
            {
                // Update clock
                //if(checkedRadioButton.Text == "Digital")
                updateClock(checkedRadioButton);

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

            public void UpdateTime()
            {
                clock.update();
            }

            private void updateClock(object sender)
            {
                // Make the radio button
                RadioButton rButton = (RadioButton)sender;

                // Display as digital or analogue
                switch (rButton.Text)
                {
                    case "Digital": 
                        update(new Digital(lDigitalTime)); 
                        break;
                    case "Analogue": 
                        update(new Analogue(analogClock));
                        break;
                    case "Binary": 
                        update(new Binary(pBinary)); 
                        break;
                }                    
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
            void update();
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

            void IClock.update()
            {
                DateTime date = DateTime.Now;
                // Displays just the time no date
                digitalClock.Text = date.ToString("hh:mm:ss tt");
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
            void IClock.update()
            {
               
                
            }            
        }

        class Binary : IClock
        {
            private const int SIZE = 25;
            private const int COLS = 6;
            private const int ROWS = 4;

            Panel pBinary;
            Graphics canvas;

            public Binary(Panel pBinary) 
            {
                this.pBinary = pBinary;
                canvas = pBinary.CreateGraphics();
            }

            void IClock.show()
            {
                pBinary.Visible = true;
            }

            void IClock.hide()
            {
                pBinary.Visible = false;
            }
            void IClock.update()
            {
                DateTime Time = DateTime.Now;                                
                //                

                Draw(Time.Hour.ToString("D2") + "" + Time.Minute.ToString("D2") + "" + Time.Second.ToString("D2"));                
            }

            void Draw(string time) 
            {
                canvas.Clear(pBinary.BackColor);

                for (int col = 0; col < COLS; col++)
                {
                    for (int row = 0; row < ROWS; row++)
                    {
                        int number = Convert.ToInt16(time[col]);
                        int bitPosition = (ROWS - 1) - row; // populates row from bottom

                        // If correct position then draw
                        if (ReadBit(number, bitPosition) == 1)
                            canvas.FillRectangle(Brushes.White, (col * SIZE), (row * SIZE), SIZE, SIZE);

                        // Draw grid
                        canvas.DrawRectangle(new Pen(Brushes.Black), (col * SIZE), (row * SIZE), SIZE, SIZE);
                    }
                }
            }
            
            int ReadBit(int number, int bitPosition)
            {
                int i = number & (1 << bitPosition); //i=2^^bitposition
                return (i > 0 ? 1 : 0);
            }
        }
    }
}
