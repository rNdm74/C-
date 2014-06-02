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

        public ListBox lbOtherQueue;
        public ListBox lbCarStereoQueue;
        public ListBox lbStatisticsResults;
        public List<Entity> leavingEntities;

        public Calender calender { get; set; }
        public ResourceManager resourceMananger { get; set; }

        public double ResourseOtherWorkTime { get; set; }
        public double ResourseCarStereoWorkTime { get; set; }
        public double ResourseWorkTime { get; set; }
        public double SystemTime { get; set; }

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


        public DataGridView dgvCalender;
        public DataGridView dgvStatistics;

        public Statistics(DataGridView dgvCalender, DataGridView dgvStatistics, ListBox lbOtherQueue, ListBox lbCarStereoQueue, ListBox lbStatisticsResults) 
        {
            this.dgvCalender = dgvCalender;
            this.dgvStatistics = dgvStatistics;

            this.lbOtherQueue = lbOtherQueue;
            this.lbCarStereoQueue = lbCarStereoQueue;
            this.lbStatisticsResults = lbStatisticsResults;

            this.leavingEntities = new List<Entity>();

            // Set variables to 0
            BusySignalCount = CallCompletion = ExcessiveWaitCount = ResourceUtilization = Iterations = ResourcesUsed = 0;
            AverageWaitingTime = AverageSystemTime = AverageNumberWaiting = ResourseOtherWorkTime = ResourseCarStereoWorkTime = ResourseWorkTime = SystemTime = 0;
        }

        private string[] getRowData(Event currentEvent, Entity currentEntity) 
        {
            // Get statistics
            string entityID = currentEntity.ID.ToString();
            string eventType = (currentEvent == null) ? "---" : currentEvent.EventType.ToString();
            string eventTime = (currentEvent == null) ? "---" : currentEvent.EventTime.ToShortTimeString();
            string entityCallType = (currentEntity.CallType == null) ? "---" : currentEntity.CallType.ToString();
            string entityStartTime = (currentEntity.StartTime.ToString("yyyy").Equals("0001")) ? "---" : currentEntity.StartTime.ToShortTimeString();
            string entityBeginWait = (currentEntity.BeginWait.ToString("yyyy").Equals("0001")) ? "---" : currentEntity.BeginWait.ToShortTimeString();

            // return data string array
            return new string[] { entityID, eventType, eventTime, entityCallType, entityStartTime, entityBeginWait }; 
        }

        public void Update() 
        {
            ///
            /// Display the calender in realtime
            ///
            Update(dgvCalender);
            
            ///
            /// Show entities in the queues
            ///
            Update(lbOtherQueue, ECallType.OTHER);
            Update(lbCarStereoQueue, ECallType.CAR_STEREO);
        }

        private void Update(DataGridView dataGridView) 
        {
            // Clear the data grid view rows
            dataGridView.Rows.Clear();

            // Add row data
            for (int i = 0; i < calender.events.Count; i++)
            {
                Event currentEvent = calender.events[i];
                // Get events entity
                Entity eventEntity = currentEvent.CurrentEntity;

                // Get event row data
                string[] rowData = getRowData(currentEvent, eventEntity);

                // Add new row
                dataGridView.Rows.Add(rowData);
            }

            // Refresh the data grid view
            dataGridView.Refresh();
        }

        private void Update(ListBox listBox, ECallType callType) 
        {
            // Clear the items in the listbox
            listBox.Items.Clear();

            // Get the entityIDs from the calltype queue
            List<string> entityIDs = resourceMananger.GetQueueEntityIDs(callType);

            // Add list of entityIDs to the listbox items
            listBox.Items.AddRange(entityIDs.ToArray());

            // Refresh the listbox
            listBox.Refresh();
        }

        public void ComputeStatistics() 
        {
            ///
            /// Update Entity Statistics 
            ///

            // Clear the display
            dgvStatistics.Rows.Clear();

            // Loop through all the enititys that left the system
            foreach (Entity entity in leavingEntities)
            {
                // Count for running averages
                count++;

                // Display the entities that left the system
                string[] entityData = getRowData(null, entity);
                dgvStatistics.Rows.Add(entityData);

                // If the entity waited
                if (!entity.BeginWait.ToString("yyyy").Equals("0001"))
                {
                    // Running average of the wait time of entities
                    double waitTime = entity.EndTime.Subtract(entity.BeginWait).TotalMinutes;
                    AverageWaitingTime += Compute(waitTime, AverageWaitingTime, count);

                    // Running average of entities waiting
                    AverageNumberWaiting++;
                    AverageNumberWaiting += Compute(1, AverageNumberWaiting, count);

                    // Work aout if call had an excessive wait time
                    if (waitTime > Constants.EXCESSIVE_WAIT_TIME)
                    {
                        ExcessiveWaitCount++;
                    }
                }

                // Average time entity takes to get through the system
                double sysTime = entity.EndTime.Subtract(entity.StartTime).TotalMinutes;
                AverageSystemTime += Compute(sysTime, AverageSystemTime, count);
            }

            ///
            /// Update Result Data
            ///
            lbStatisticsResults.Items.Clear();
            lbStatisticsResults.Items.Add("Bus Signal Count: " + BusySignalCount);
            lbStatisticsResults.Items.Add("Call Completions: " + CallCompletion);
            lbStatisticsResults.Items.Add("Excessive Wait Count: " + ExcessiveWaitCount);
            lbStatisticsResults.Items.Add("Average Wait Time: " + AverageWaitingTime);
            lbStatisticsResults.Items.Add("Average System Time: " + AverageSystemTime);
            lbStatisticsResults.Items.Add("Average Number Waiting: " + AverageNumberWaiting);
            lbStatisticsResults.Items.Add("Other Utilization: " + (ResourseOtherWorkTime / Constants.MAX_RESOURCES_OTHER) / SystemTime);
            lbStatisticsResults.Items.Add("Car Stereo Utilization: " + (ResourseCarStereoWorkTime / Constants.MAX_RESOURCES_CAR_STEREO) / SystemTime);
            lbStatisticsResults.Items.Add("Resource Utilization Total: " + (ResourseWorkTime / (Constants.MAX_RESOURCES_CAR_STEREO + Constants.MAX_RESOURCES_OTHER)) / SystemTime);//(SystemTime / ResourseWorkTime));
            lbStatisticsResults.Refresh();
            
        }

        public double Compute(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }
    }
}
