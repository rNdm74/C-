using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1.project.DiscreteEventSimulator
{
    class Statistics
    {
        public ListBox lbCalender;
        public ListBox lbOtherQueue;
        public ListBox lbCarStereoQueue;
        public List<Entity> leavingEntities;

        public Calender calender { get; set; }
        public ResourceManager resourceMananger { get; set; }

        public Statistics(ListBox lbCalender, ListBox lbOtherQueue, ListBox lbCarStereoQueue) 
        {
            this.lbCalender = lbCalender;
            this.lbOtherQueue = lbOtherQueue;
            this.lbCarStereoQueue = lbCarStereoQueue;
            this.leavingEntities = new List<Entity>();
        }

        public void Update() 
        {
            lbCalender.Items.Clear();

            for (int i = 0; i < calender.events.Count; i++)
            {
                lbCalender.Items.Add(calender.events[i].EventTime.ToString() + " " + calender.events[i].EventType.ToString());
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
        }

        // Busy Signal count
        public int BusySignalCount      { get; set; }

        // Completion Count
        public int CallCompletion       { get; set; }

        // Excessive Wait Count
        public int ExcessiveWaitCount   { get; set; }

        // Resource Utilization
        public int ResourceUtilization  { get; set; }

        // Average Number Waiting
        public int AverageNumberWaiting { get; set; }

        // Average Waiting Time
        public int AverageWaitingTime   { get; set; }

        // Average System Time
        public int AverageSystemTime    { get; set; }
    }
}
