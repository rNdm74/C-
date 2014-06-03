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
        protected IStatistics statisticsSubject;

        public Display(IStatistics statisticsSubject) 
        {
            this.statisticsSubject = statisticsSubject;

            // IMPORTANT
            statisticsSubject.AddDisplay(this);
        }

        public abstract void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics);
        public abstract void Draw();
    }

    class Graphical : Display
    {
        private Graphics canvas;

        public Graphical(IStatistics statisticsSubject, Panel pGraphical)
            : base(statisticsSubject)
        {
            canvas = pGraphical.CreateGraphics();
        }

        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            //throw new NotImplementedException();
        }

        public override void Draw()
        {
            //throw new NotImplementedException();
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

        public Text(IStatistics statisticsSubject, DataGridView dgvCalender, DataGridView dgvOtherQueue, DataGridView dgvCarStereoQueue)
            : base(statisticsSubject)
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
            DataGridViewDraw(dgvCalender, calenderData);
            DataGridViewDraw(dgvOtherQueue, otherQueueData);
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

        private int iterations;
        private int resourcesUsed;
        private int busySignalCount;
        private int callCompletion;
        private int excessiveWaitCount;

        private double resourceUtilization;
        private double resourseOtherWorkTime;
        private double resourseCarStereoWorkTime;
        private double resourseWorkTime;
        private double systemTime;
        private double averageNumberWaiting;
        private double averageWaitingTime;
        private double averageSystemTime;

        public Results(IStatistics statisticsSubject, DataGridView dgvStatistics, ListBox lbStatisticsResults)
            : base(statisticsSubject)
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
            excessiveWaitCount = statistics.ExcessiveWaitCount;
            averageWaitingTime = statistics.AverageWaitingTime;
            averageSystemTime = statistics.AverageSystemTime;
            averageNumberWaiting = statistics.AverageNumberWaiting;
            resourseOtherWorkTime = (statistics.ResourseOtherWorkTime / Constants.MAX_RESOURCES_OTHER) / statistics.SystemTime;
            resourseCarStereoWorkTime = (statistics.ResourseCarStereoWorkTime / Constants.MAX_RESOURCES_CAR_STEREO) / statistics.SystemTime;
            resourceUtilization = (statistics.ResourseWorkTime / (Constants.MAX_RESOURCES_OTHER + Constants.MAX_RESOURCES_CAR_STEREO)) / statistics.SystemTime;
        }

        public override void Draw()
        {
            ///
            /// Draw data to listbox
            ///

            lbStatisticsResults.Items.Clear();
            lbStatisticsResults.Items.Add("Bus Signal Count: " + busySignalCount);
            lbStatisticsResults.Items.Add("Call Completions: " + callCompletion);
            lbStatisticsResults.Items.Add("Excessive Wait Count: " + excessiveWaitCount);
            lbStatisticsResults.Items.Add("Average Wait Time: " + averageWaitingTime);
            lbStatisticsResults.Items.Add("Average System Time: " + averageSystemTime);
            lbStatisticsResults.Items.Add("Average Number Waiting: " + averageNumberWaiting);
            lbStatisticsResults.Items.Add("Other Utilization: " + resourseOtherWorkTime);
            lbStatisticsResults.Items.Add("Car Stereo Utilization: " + resourseCarStereoWorkTime);
            lbStatisticsResults.Items.Add("Resource Utilization Total: " + resourceUtilization);
            lbStatisticsResults.Refresh();
        }
    }
}
