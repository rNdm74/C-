using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1.project.DiscreteEventSimulator
{
    class Statistics
    {
        int count = 0;
        public ListBox lbCalender;
        public ListBox lbOtherQueue;
        public ListBox lbCarStereoQueue;
        public ListBox lbStatistics;
        public ListBox lbStatisticsResults;
        public List<Entity> leavingEntities;

        public Calender calender { get; set; }
        public ResourceManager resourceMananger { get; set; }

        // Busy Signal count
        public int BusySignalCount { get; set; }

        // Completion Count
        public int CallCompletion { get; set; }

        // Excessive Wait Count
        public int ExcessiveWaitCount { get; set; }

        // Resource Utilization
        public int ResourceUtilization { get; set; }

        // Average Number Waiting
        public double AverageNumberWaiting { get; set; }

        // Average Waiting Time
        public double AverageWaitingTime { get; set; }

        // Average System Time
        public double AverageSystemTime { get; set; }

        public int Iterations { get; set; }
        public int ResourcesUsed { get; set; }

        public Statistics(ListBox lbCalender, ListBox lbOtherQueue, ListBox lbCarStereoQueue, ListBox lbStatistics, ListBox lbStatisticsResults) 
        {
            this.lbCalender = lbCalender;
            this.lbOtherQueue = lbOtherQueue;
            this.lbCarStereoQueue = lbCarStereoQueue;
            this.lbStatistics = lbStatistics;
            this.lbStatisticsResults = lbStatisticsResults;

            this.leavingEntities = new List<Entity>();

            BusySignalCount = CallCompletion = ExcessiveWaitCount = ResourceUtilization = Iterations = ResourcesUsed = 0;
            AverageWaitingTime = AverageSystemTime = AverageNumberWaiting = 0;
        }

        public void Update() 
        {
            lbCalender.Items.Clear();

            for (int i = 0; i < calender.events.Count; i++)
            {
                lbCalender.Items.Add(calender.events[i].EventTime.ToString("hh:mm:ss") + "\t\t" + calender.events[i].EventType.ToString());
            }

            lbCalender.Refresh();

            lbOtherQueue.Items.Clear();

            Queue queue0 = resourceMananger.queueManager.simulatorQueues[0];

            for (int i = 0; i < queue0.entityQueue.Count(); i++)
            {
                lbOtherQueue.Items.Add(queue0.entityQueue[i].ID.ToString());
            }

            lbOtherQueue.Refresh();

            lbCarStereoQueue.Items.Clear();

            Queue queue1 = resourceMananger.queueManager.simulatorQueues[1];

            for (int i = 0; i < queue1.entityQueue.Count(); i++)
            {
                lbCarStereoQueue.Items.Add(queue1.entityQueue[i].ID.ToString());
            }

            lbCarStereoQueue.Refresh();


            

            //MessageBox.Show(sb.ToString());
        }


        public void ComputeStatistics() 
        {
            lbStatistics.Items.Clear();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("#" + "\t" + "StartTime" + "\t" + "BeginWait" + "\t" + "EndTime" + "\t" + "CallType" + "\n");
            lbStatistics.Items.Add("#" + " | " + "StartTime" + " | " + "BeginWait" + " | " + "EndTime" + " | " + "CallType");
            //lbStatistics.Items.Add("");


            foreach (Entity entity in leavingEntities)
            {
                count++;

                string startTime = entity.StartTime.ToString("hh:mm:ss");

                string beginWait = "---";

                if (!entity.BeginWait.ToString("yyyy").Equals("0001"))
                {
                    beginWait = entity.BeginWait.ToString("hh:mm:ss");

                    double waitTime = entity.EndTime.Subtract(entity.BeginWait).TotalMinutes;
                    AverageWaitingTime += Compute(waitTime, AverageWaitingTime, count);
                    AverageNumberWaiting++;
                    AverageNumberWaiting += Compute(1, AverageNumberWaiting, count);

                    if (waitTime > 1)
                    {
                        ExcessiveWaitCount++;
                    }
                }

                string endTime = entity.EndTime.ToString("hh:mm:ss");

                double sysTime = entity.EndTime.Subtract(entity.StartTime).TotalMinutes;
                AverageSystemTime += Compute(sysTime, AverageSystemTime, count);
                

                //sb.Append(entity.ID + "\t" + startTime + "\t" + beginWait + "\t" + endTime + "\t" + entity.CallType + "\n");
                lbStatistics.Items.Add(entity.ID + " | " + startTime + " | " + beginWait + " | " + endTime + " | " + entity.CallType);
            }

            lbStatistics.Refresh();

            lbStatisticsResults.Items.Clear();
            //lbStatisticsResults.Items.Add("");
            lbStatisticsResults.Items.Add("Bus Signal Count: " + BusySignalCount);
            lbStatisticsResults.Items.Add("Call Completions: " + CallCompletion);
            lbStatisticsResults.Items.Add("Excessive Wait Count: " + ExcessiveWaitCount);
            lbStatisticsResults.Items.Add("Average Wait Time: " + AverageWaitingTime);
            lbStatisticsResults.Items.Add("Average System Time: " + AverageSystemTime);
            lbStatisticsResults.Items.Add("Average Number Waiting: " + AverageNumberWaiting);
            lbStatisticsResults.Items.Add("Resource Utilization: " + ResourcesUsed);
            lbStatisticsResults.Refresh();
            
        }

        public double Compute(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }
    }
}
