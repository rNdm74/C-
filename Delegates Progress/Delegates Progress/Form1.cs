using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegates_Progress
{
    public partial class Form1 : Form
    {
        private delegate void FeedbackDelegate();
        private FeedbackDelegate feedBackDelegate;
        private bool finishedWork = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feedBackDelegate = null;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            ResetControls();

            // Assign method based on checked radiobutton
            if (rbSpinBox.Checked)
                feedBackDelegate = new FeedbackDelegate(updateSpinBox);

            if (rbProgressBar.Checked) 
                feedBackDelegate = new FeedbackDelegate(updateProgressBar);

            if (rbTrackBar.Checked)
                feedBackDelegate = new FeedbackDelegate(updateTrackBar);

            // Execute worker
            slowMethod(feedBackDelegate);
        }

        private void slowMethod(FeedbackDelegate feedBackDelegate) 
        {
            // Reset flag
            finishedWork = false;

            while (!finishedWork)
            {
                // Do some work
                System.Threading.Thread.Sleep(100);

                // Update progress
                feedBackDelegate();
            }

            // Give feedback when done
            MessageBox.Show("Work Done");
        }

        private void updateSpinBox() 
        {
            if (nUpDown.Value < nUpDown.Maximum)
                nUpDown.Value++;
            else
                finishedWork = true; // Set flag to stop loop

            // Update Display
            nUpDown.Refresh();
        }

        private void updateProgressBar()
        {
            if(pBar.Value < pBar.Maximum)
                pBar.PerformStep();
            else
                finishedWork = true; // Set flag to stop loop

            // Update Display
            pBar.Refresh();
        }

        private void updateTrackBar() 
        {
            if (tBar.Value < tBar.Maximum)
                tBar.Value++;
            else
                finishedWork = true; // Set flag to stop loop

            // Update Display
            tBar.Refresh();
        }

        private void ResetControls() 
        {
            nUpDown.Value = 0;
            pBar.Value = 0;
            tBar.Value = 0;

            nUpDown.Refresh();
            pBar.Refresh();
            tBar.Refresh();
        }
    }
}
