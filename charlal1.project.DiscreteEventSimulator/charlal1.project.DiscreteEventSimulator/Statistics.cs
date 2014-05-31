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
        public ListBox lbQueues;

        public Calender calender { get; set; }
        public ResourceManager resourceMananger { get; set; }

        public Statistics(ListBox lbCalender, ListBox lbQueues) 
        {
            this.lbCalender = lbCalender;
            this.lbQueues = lbCalender;
        }

        public void Update() 
        {
            lbCalender.Items.Clear();

            for (int i = 0; i < calender.events.Count; i++)
            {
                lbCalender.Items.Add(calender.events[i].EventTime.ToString() + " " + calender.events[i].EventType.ToString());
            }

            lbCalender.Refresh();

            //lbQueues.Items.Clear();

            //Queue queue0 = resourceMananger.queueManager.simulatorQueues[0];
            ////Queue queue1 = resourceMananger.queueManager.simulatorQueues[1];

            ////String queueList0 = "";

            //for (int i = 0; i < queue0.Count(); i++)
            //{
            //    //lbQueues.Items.Add(queue0.entityQueue[i].ID.ToString());
            //}

            //lbQueues.Refresh();
        }

        // Busy Signal Count
        // Completion Count
        // Excessive Wait Count
        // Resource Utilization
        // Average Number Waiting
        // Average Waiting Time
        // Average System Time
    }
}
