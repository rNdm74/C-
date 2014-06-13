using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace charlal1.project.DiscreteEventSimulator
{
    /// <summary>
    /// Observer
    /// </summary>
    /// 
    interface IDisplay
    {
        void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics);
        void Draw();
    }

    /// <summary>
    /// Observer Pattern Class gets data from the statistics subject class
    /// </summary>
    abstract class Display : IDisplay
    {
        //
        protected delegate void SetCallBack();
        protected IStatistics statisticsSubject;
        protected Form1 mainForm;

        public Display(IStatistics statisticsSubject, Form1 mainForm) 
        {
            this.statisticsSubject = statisticsSubject;
            this.mainForm = mainForm;

            // IMPORTANT
            statisticsSubject.AddDisplay(this);
        }

        public abstract void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics);
        public abstract void Draw();
    }

    /// <summary>
    /// Graphical, it displays the simulation information with a graphical representation of the simulation data 
    /// </summary>
    class Graphical : Display
    {
        private GraphicalDisplay gDisplay;
        private Panel pGraphical;

        public Graphical(IStatistics statisticsSubject, Form1 mainForm, Panel pGraphical)
            : base(statisticsSubject, mainForm)
        {
            this.pGraphical = pGraphical;
            this.gDisplay = new GraphicalDisplay(pGraphical);
        }

        /// <summary>
        /// Update the information from the main simulation
        /// </summary>
        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            gDisplay.Update(calender, resourceMananger, statistics);
        }

        /// <summary>
        /// Draw the graphical view to the panel
        /// </summary>
        public override void Draw()
        {
            if (pGraphical.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(gDisplay.Draw);
                mainForm.Invoke(d);
            }
            else 
            {
                // It's on the same thread, no need for Invoke
                gDisplay.Draw();
            }
        }
    }

    class Text : Display
    {
        private DataGridView dgvCalender;
        private DataGridView dgvOtherQueue;
        private DataGridView dgvCarStereoQueue;

        private List<string[]> calenderData;
        private List<string[]> otherQueueData;
        private List<string[]> carStereoQueueData;

        public Text(IStatistics statisticsSubject, Form1 mainForm, DataGridView dgvCalender, DataGridView dgvOtherQueue, DataGridView dgvCarStereoQueue)
            : base(statisticsSubject, mainForm)
        {
            this.dgvCalender = dgvCalender;
            this.dgvOtherQueue = dgvOtherQueue;
            this.dgvCarStereoQueue = dgvCarStereoQueue;
        }

        /// <summary>
        /// Update the information from the main simulation
        /// </summary>
        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            calenderData = calender.GetEventData();
            otherQueueData = resourceMananger.GetQueueEntityData(ECallType.OTHER);
            carStereoQueueData = resourceMananger.GetQueueEntityData(ECallType.CAR_STEREO);
        }

        /// <summary>
        /// Draw the datagrid views with updated information
        /// </summary>
        public override void Draw()
        {
            if (dgvCalender.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(DrawCalender);
                mainForm.Invoke(d);
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                DrawCalender();
            }

            if (dgvOtherQueue.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(DrawOtherQueue);
                mainForm.Invoke(d);
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                DrawOtherQueue();
            }
                
            if(dgvCarStereoQueue.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(DrawCarStereoQueue);
                mainForm.Invoke(d);
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                DrawCarStereoQueue();
            }
        }

        /// <summary>
        /// Draw the calender queue
        /// </summary>
        private void DrawCalender() 
        {
            dataGridViewDraw(dgvCalender, calenderData);
        }

        /// <summary>
        /// Draw the other resource queue
        /// </summary>
        private void DrawOtherQueue() 
        {
            dataGridViewDraw(dgvOtherQueue, otherQueueData);
        }

        /// <summary>
        /// Draw the car stereo resource queue
        /// </summary>
        private void DrawCarStereoQueue() 
        {
            dataGridViewDraw(dgvCarStereoQueue, carStereoQueueData);
        }

        /// <summary>
        /// Populate the datagridview rows with simulation data
        /// </summary>
        private void dataGridViewDraw(DataGridView dataGridView, List<string[]> data) 
        {
            // Clear the data grid view rows
            dataGridView.Rows.Clear();

            // Adds data to the rows
            foreach (string[] s in data)
                dataGridView.Rows.Add(s);

            // Refresh the view
            dataGridView.Refresh();
        }
    }

    class Stats : Display
    {
        private DataGridView dgvStatistics;
        private ProgressBar pBar;
        private string timeObs;

        public Stats(IStatistics statisticsSubject, Form1 mainForm, DataGridView dgvStatistics, ProgressBar pBar)
            : base(statisticsSubject, mainForm)
        {
            this.dgvStatistics = dgvStatistics;
            this.pBar = pBar;

            // Displays the system running time from seconds
            TimeSpan t = TimeSpan.FromSeconds(Global.SystemTime);
            timeObs = string.Format("{0:D1}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
        }

        /// <summary>
        /// Update status bar no information from the main simulation is used
        /// </summary>
        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {   
            if (pBar.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(UpdateProgress);
                mainForm.Invoke(d);
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                pBar.Value = Global.Clock;
            }
        }

        private void UpdateProgress()
        {
            pBar.Value = Global.Clock;
        }

        /// <summary>
        /// Draw data to listbox
        /// </summary>
        public override void Draw()
        {
            if (dgvStatistics.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(DrawStatistics);
                mainForm.Invoke(d);
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                DrawStatistics();
            }
        }
        
        

        /// <summary>
        /// Draw data to listbox
        /// </summary>
        private void DrawStatistics() 
        {
            dgvStatistics.Rows.Clear();
            dgvStatistics.Rows.Add(new String[] { "Bus Signal Count",                           Global.BusySignalCount.ToString(),                      "---" });
            dgvStatistics.Rows.Add(new String[] { "Call Completions",                           Global.CallCompletion.ToString(),                       "---" });
            dgvStatistics.Rows.Add(new String[] { "Call Completions " + Constants.TYPE_1,       Global.CallCompletionType1.ToString(),                  "---" });
            dgvStatistics.Rows.Add(new String[] { "Call Completions " + Constants.TYPE_2,       Global.CallCompletionType2.ToString(),                  "---" });
            dgvStatistics.Rows.Add(new String[] { "Excessive Wait Count",                       Global.ExcessiveWaitCount.ToString(),                   "---" });
            dgvStatistics.Rows.Add(new String[] { "Excessive Wait Count " + Constants.TYPE_1,   Global.ExcessiveWaitCountType1.ToString(),              "---" });
            dgvStatistics.Rows.Add(new String[] { "Excessive Wait Count " + Constants.TYPE_2,   Global.ExcessiveWaitCountType2.ToString(),              "---" });
            dgvStatistics.Rows.Add(new String[] { "Average Wait Time",                          Global.AverageWaitingTime.ToString("0 min"),            timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average System Time",                        Global.AverageSystemTime.ToString("0 min"),             timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average Number Waiting",                     Global.AverageNumberWaiting.ToString("0"),              timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average Waiting " + Constants.TYPE_1,        Global.AverageNumberWaitingType1.ToString("0.0"),       timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average Waiting " + Constants.TYPE_2,        Global.AverageNumberWaitingType2.ToString("0.0"),       timeObs });
            dgvStatistics.Rows.Add(new String[] { "Resource Utilization " + Constants.TYPE_1,   Global.ResourceType1Utilization.ToString("0.##%"),      timeObs });
            dgvStatistics.Rows.Add(new String[] { "Resource Utilization " + Constants.TYPE_2,   Global.ResourceType2Utilization.ToString("0.##%"),      timeObs });
            dgvStatistics.Rows.Add(new String[] { "Resource Utilization Total",                 Global.ResourceUtilization.ToString("0.##%"),           timeObs });
            dgvStatistics.Refresh();
        }
    }
}
