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
        private Panel pGraphical;
        private List<String[]> otherQueue;
        private List<String[]> carStereoQueue;
        private List<String[]> calenderList;

        public Graphical(IStatistics statisticsSubject, Panel pGraphical)
            : base(statisticsSubject)
        {
            this.pGraphical = pGraphical;
        }

        public override void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            otherQueue = resourceMananger.GetQueueEntityData(ECallType.OTHER);
            carStereoQueue = resourceMananger.GetQueueEntityData(ECallType.CAR_STEREO);
            calenderList = calender.GetEventData();
        }

        public override void Draw()
        {
            pGraphical.Controls.Clear();

            Label arrivalEntity = new Label();
            Label ivrEntity = new Label(); ;
            List<Label> resourcesCarStereo = new List<Label>();
            List<Label> resourcesOther = new List<Label>();

            int count = 0;

            Label arrival = new Label();
            arrival.Text = "ARRIVAL";
            arrival.Location = new Point(32, 64);
            pGraphical.Controls.Add(arrival);

            Label ivr = new Label();
            ivr.Text = "IVR";
            ivr.Location = new Point((arrival.Location.X + arrival.Width), 64);
            pGraphical.Controls.Add(ivr);

            Label queueOther = new Label();
            queueOther.Text = "OTHER_QUEUE";
            queueOther.AutoSize = true;
            queueOther.Location = new Point(ivr.Location.X + ivr.Width, 32);
            pGraphical.Controls.Add(queueOther);

            Label queueCarStereo = new Label();
            queueCarStereo.Text = "CAR_STEREO_QUEUE";
            queueCarStereo.AutoSize = true;
            queueCarStereo.Location = new Point(ivr.Location.X + ivr.Width, 128);
            pGraphical.Controls.Add(queueCarStereo);

            Label resourceOther = new Label();
            resourceOther.Text = "RESOURCE_OTHER";
            resourceOther.AutoSize = true;
            resourceOther.Location = new Point(pGraphical.Right - 300, 32);
            pGraphical.Controls.Add(resourceOther);

            Label resourceCarStereo = new Label();
            resourceCarStereo.Text = "RESOURCE_CAR_STEREO";
            resourceCarStereo.AutoSize = true;
            resourceCarStereo.Location = new Point(pGraphical.Right - 300, 128);
            pGraphical.Controls.Add(resourceCarStereo);


            foreach (String[] eventData in calenderList)
            {
                if (eventData[1].Equals(EEventType.ARRIVAL.ToString()))
                {
                    String id = eventData[0];
                    arrivalEntity = Entity(id, ECallType.CAR_STEREO, new Point(arrival.Left, arrival.Bottom), System.Drawing.Color.LightGreen);
                }

                if (eventData[1].Equals(EEventType.SWITCH_COMPLETE.ToString()))
                {
                    String id = eventData[0];
                    ivrEntity = Entity(id, ECallType.CAR_STEREO, new Point(ivr.Left, ivr.Bottom), System.Drawing.Color.LightGoldenrodYellow);
                }

                if (eventData[1].Equals(EEventType.PROCESSING_COMPLETE.ToString()) && eventData[3].Equals(ECallType.OTHER.ToString()))
                {
                    String id = eventData[0];
                    resourcesOther.Add(Entity(id, ECallType.OTHER, new Point(resourceOther.Left, resourceOther.Bottom + (count * 32)), System.Drawing.Color.LightPink));

                    count++;
                }

                if (eventData[1].Equals(EEventType.PROCESSING_COMPLETE.ToString()) && eventData[3].Equals(ECallType.CAR_STEREO.ToString()))
                {
                    String id = eventData[0];
                    resourcesCarStereo.Add(Entity(id, ECallType.CAR_STEREO, new Point(resourceCarStereo.Left, resourceCarStereo.Bottom), System.Drawing.Color.LightBlue));
                }
            }

            pGraphical.Controls.Add(arrivalEntity);
            pGraphical.Controls.Add(ivrEntity);
            foreach (Label l in resourcesOther)
                pGraphical.Controls.Add(l);
            foreach (Label l in resourcesCarStereo)
                pGraphical.Controls.Add(l);

            pGraphical.Controls.Add(arrivalEntity);

            

            for (int col = 0; col < carStereoQueue.Count; col++)
            {
                String id = carStereoQueue[col][0];
                Label entity = Entity(id, ECallType.CAR_STEREO, new Point(queueCarStereo.Left + (32 * (carStereoQueue.Count - col)), queueCarStereo.Bottom), System.Drawing.Color.LightBlue);
                pGraphical.Controls.Add(entity);
            }

            for (int col = 0; col < otherQueue.Count; col++)
            {
                String id = otherQueue[col][0];
                Label entity = Entity(id, ECallType.CAR_STEREO, new Point(queueOther.Left + (32 * (otherQueue.Count - col)), queueOther.Bottom), System.Drawing.Color.LightPink);
                pGraphical.Controls.Add(entity);
            }

            pGraphical.Refresh();
        }

        private Label Entity(string ID, ECallType callType, Point location, Color color) 
        {
            Label label = new Label();
            label.BackColor = color;//()System.Drawing.Color.Gainsboro;
            label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label.Location = location;
            label.Name = ID;
            label.Size = new System.Drawing.Size(32, 32);
            label.Text = ID;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return label;
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
