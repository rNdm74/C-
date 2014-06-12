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

    abstract class Display : IDisplay
    {
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

        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            gDisplay.Update(calender, resourceMananger, statistics);
        }

        public override void Draw()
        {
            if (pGraphical.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(gDisplay.Draw);
                mainForm.Invoke(d);
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

        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            calenderData = calender.GetEventData();
            otherQueueData = resourceMananger.GetQueueEntityData(ECallType.OTHER);
            carStereoQueueData = resourceMananger.GetQueueEntityData(ECallType.CAR_STEREO);
        }

        public override void Draw()
        {
            if (dgvCalender.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(DrawCalender);
                mainForm.Invoke(d);
            }

            if (dgvOtherQueue.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(DrawOtherQueue);
                mainForm.Invoke(d);
            }
                
            if(dgvCarStereoQueue.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(DrawCarStereoQueue);
                mainForm.Invoke(d);
            }
        }

        private void DrawCalender() 
        {
            DataGridViewDraw(dgvCalender, calenderData);
        }

        private void DrawOtherQueue() 
        {
            DataGridViewDraw(dgvOtherQueue, otherQueueData);
        }

        private void DrawCarStereoQueue() 
        {
            DataGridViewDraw(dgvCarStereoQueue, carStereoQueueData);
        }

        private void DataGridViewDraw(DataGridView dataGridView, List<string[]> data) 
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
        }

        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            ///
            /// Update Result Data
            ///            
            TimeSpan t = TimeSpan.FromSeconds(Global.SystemTime);
            timeObs = string.Format("{0:D1}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);

            if (pBar.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(UpdateProgress);
                mainForm.Invoke(d);
            }
        }

        public override void Draw()
        {
            if (dgvStatistics.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(DrawStatistics);
                mainForm.Invoke(d);
            }
        }
        
        private void UpdateProgress()
        {
            pBar.Value = Global.Clock;
        }

        private void DrawStatistics() 
        {
            // Draw data to listbox
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
