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

    class Results : Display
    {
        private DataGridView dgvStatistics;
        private ListBox lbStatisticsResults;

        private int busySignalCount;
        private int callCompletion;
        private int callCompletionOther;
        private int callCompletionCarStereo;
        private int excessiveWaitCount;
        private int excessiveWaitCountOther;
        private int excessiveWaitCountCarStereo;

        private double resourceUtilization;
        private double resourseOtherWorkTime;
        private double resourseCarStereoWorkTime;
        private double averageNumberWaiting;
        private double averageNumberWaitingOther;
        private double averageNumberWaitingCarStereo;
        private double averageWaitingTime;
        private double averageSystemTime;

        private string timeObs;

        public Results(IStatistics statisticsSubject, Form1 mainForm, DataGridView dgvStatistics, ListBox lbStatisticsResults)
            : base(statisticsSubject, mainForm)
        {
            this.dgvStatistics = dgvStatistics;
            this.lbStatisticsResults = lbStatisticsResults;
        }

        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            ///
            /// Update Result Data
            ///
            
            busySignalCount = statistics.BusySignalCount;
            callCompletion = statistics.CallCompletion;
            callCompletionOther = statistics.CallCompletionOther;
            callCompletionCarStereo = statistics.CallCompletionCarStereo;
            excessiveWaitCount = statistics.ExcessiveWaitCount;
            excessiveWaitCountOther = statistics.ExcessiveWaitCountOther;
            excessiveWaitCountCarStereo = statistics.ExcessiveWaitCountCarStereo;
            averageWaitingTime = statistics.AverageWaitingTime;
            averageSystemTime = statistics.AverageSystemTime;
            averageNumberWaiting = statistics.AverageNumberWaiting;
            averageNumberWaitingOther = statistics.AverageNumberWaitingOther;
            averageNumberWaitingCarStereo = statistics.AverageNumberWaitingCarStereo;
            resourseOtherWorkTime = (statistics.ResourseOtherWorkTime / Constants.MAX_RESOURCES_OTHER) / statistics.SystemTime;
            resourseCarStereoWorkTime = (statistics.ResourseCarStereoWorkTime / Constants.MAX_RESOURCES_CAR_STEREO) / statistics.SystemTime;
            resourceUtilization = (statistics.ResourseWorkTime / (Constants.MAX_RESOURCES_OTHER + Constants.MAX_RESOURCES_CAR_STEREO)) / statistics.SystemTime;

            //timeObs = statistics.SystemTime;

            TimeSpan t = TimeSpan.FromSeconds(statistics.SystemTime);
            timeObs = string.Format("{0:D1}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
        }

        public override void Draw()
        {
            if (dgvStatistics.InvokeRequired)
            {
                SetCallBack d = new SetCallBack(DrawStatistics);
                mainForm.Invoke(d);
            }
        }

        private void DrawStatistics() 
        {
            ///
            /// Draw data to listbox
            ///

            dgvStatistics.Rows.Clear();
            dgvStatistics.Rows.Add(new String[] { "Bus Signal Count", busySignalCount.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Call Completions", callCompletion.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Call Completions Other", callCompletionOther.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Call Completions Car Stereo", callCompletionCarStereo.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Excessive Wait Count", excessiveWaitCount.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Excessive Wait Count Other", excessiveWaitCountOther.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Excessive Wait Count Car Stereo", excessiveWaitCountCarStereo.ToString(), "---" });
            dgvStatistics.Rows.Add(new String[] { "Average Wait Time", averageWaitingTime.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average System Time", averageSystemTime.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average Number Waiting", averageNumberWaiting.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average Waiting Other", averageNumberWaitingOther.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Average Waiting Car Stereo", averageNumberWaitingCarStereo.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Resource Utilization Other", resourseOtherWorkTime.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Resource Utilization Car Stereo", resourseCarStereoWorkTime.ToString(), timeObs });
            dgvStatistics.Rows.Add(new String[] { "Resource Utilization Total", resourceUtilization.ToString(), timeObs });
            dgvStatistics.Refresh();
        }
    }
}
