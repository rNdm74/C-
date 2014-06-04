using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1.project.DiscreteEventSimulator
{
    /// <summary>
    /// Subject
    /// </summary>
    /// 
    interface IStatistics 
    {
        void AddDisplay(IDisplay d);
        void RemoveDisplay(IDisplay d);
        void NotifyDisplays();
    }

    class Statistics : IStatistics
    {
        private int waitingAverageCount, waitingAverageCarStereoCount, waitingAverageOtherCount;
        private int systemAverageCount = 1;

        public Calender calender                { get; set; }
        public ResourceManager resourceMananger { get; set; }

        public int Iterations                   { get; set; }
        public int ResourcesUsed                { get; set; }
        public int BusySignalCount              { get; set; }
        public int CallCompletion               { get; set; }
        public int CallCompletionOther          { get; set; }
        public int CallCompletionCarStereo      { get; set; }
        public int ExcessiveWaitCount           { get; set; }
        public int ExcessiveWaitCountOther      { get; set; }
        public int ExcessiveWaitCountCarStereo  { get; set; }
        public int ResourceUtilization          { get; set; }

        public double ResourseOtherWorkTime     { get; set; }
        public double ResourseCarStereoWorkTime { get; set; }
        public double ResourseWorkTime          { get; set; }
        public double SystemTime                { get; set; }
                
        public double AverageNumberWaiting      { get; set; }
        public double AverageWaitingTime        { get; set; }
        public double AverageNumberWaitingOther { get; set; }
        public double AverageNumberWaitingCarStereo { get; set; }
        public double AverageSystemTime         { get; set; }
        
        public List<Entity> leavingEntities;
        private List<IDisplay> displayList;
        
        public Statistics() 
        {

            this.displayList = new List<IDisplay>();
            this.leavingEntities = new List<Entity>();

            waitingAverageCount = waitingAverageCarStereoCount = waitingAverageOtherCount = 0;

            // Set variables to 0
            BusySignalCount = CallCompletion = ExcessiveWaitCount = ResourceUtilization = Iterations = ResourcesUsed = 0;
            AverageWaitingTime = AverageSystemTime = AverageNumberWaiting = ResourseOtherWorkTime = ResourseCarStereoWorkTime = ResourseWorkTime = SystemTime = 0;
        }


        public void AddDisplay(IDisplay d)
        {
            displayList.Add(d);
        }

        public void RemoveDisplay(IDisplay d)
        {
            // Add error checking
            if(displayList.Contains(d))
                displayList.Remove(d);
        }

        public void UpdateLists(Calender calender, ResourceManager resourceMananger) 
        {
            this.calender = calender;
            this.resourceMananger = resourceMananger;
        }

        public void NotifyDisplays()
        {
            foreach (IDisplay currentDisplay in displayList)
            {
                currentDisplay.Update(calender, resourceMananger, this);
                currentDisplay.Draw();
            }
        }





        private void updateCompletions(ECallType? callType) 
        {
            switch (callType)
            {
                case ECallType.OTHER:
                    CallCompletionOther++;
                    break;
                case ECallType.CAR_STEREO:
                    CallCompletionCarStereo++;
                    break;
            }
        }

        public void UpdateEntityStatistics(Entity e)
        {
            updateCompletions(e.CallType);

            // If the entity waited
            if (!e.BeginWait.ToString("yyyy").Equals("0001"))
            {
                // Work out entity wait time
                double waitTime = e.EndTime.Subtract(e.BeginWait).TotalMinutes;

                // Update waiting averages
                UpdateAverageNumberWaiting(e.CallType);
                UpdateAverageWaitingTime(waitTime);
                UpdateExcessiveWaiting(e.CallType, waitTime);

                
            }

            // Update system time for all entities
            UpdateSystemTime(e);
        }


        private void UpdateAverageWaitingTime(double waitTime) 
        {
            // Running average of the wait time of entities
            //double waitTime = entity.EndTime.Subtract(entity.BeginWait).TotalMinutes;
            AverageWaitingTime += Compute(waitTime, AverageWaitingTime, waitingAverageCount);
        }

        private void UpdateAverageNumberWaiting(ECallType? callType) 
        {
            // Running average of entities waiting
            AverageNumberWaiting++;
            AverageNumberWaiting += Compute(1, AverageNumberWaiting, ++waitingAverageCount);

            // Increment the waiting average count
            //waitingAverageCount++;

            switch (callType)
            {
                case ECallType.CAR_STEREO:
                    AverageNumberWaitingCarStereo++;
                    AverageNumberWaitingCarStereo += Compute(1, AverageNumberWaitingCarStereo, ++waitingAverageCarStereoCount);
                    break;
                case ECallType.OTHER:
                    AverageNumberWaitingOther++;
                    AverageNumberWaitingOther += Compute(1, AverageNumberWaitingOther, ++waitingAverageOtherCount);
                    break;
            }
        }

        private void UpdateExcessiveWaiting(ECallType? callType, double waitTime) 
        {
            // Work out if call had an excessive wait time
            if (waitTime > Constants.EXCESSIVE_WAIT_TIME)
            {
                switch (callType)
                {
                    case ECallType.CAR_STEREO:
                        ExcessiveWaitCountCarStereo++;
                        break;
                    case ECallType.OTHER:
                        ExcessiveWaitCountOther++;
                        break;
                } 
   
                ExcessiveWaitCount++;
            }
        }

        private void UpdateSystemTime(Entity e) 
        {
            // Average time entity takes to get through the system
            double sysTime = e.EndTime.Subtract(e.StartTime).TotalMinutes;

            AverageSystemTime += Compute(sysTime, AverageSystemTime, systemAverageCount);

            systemAverageCount++;
        }

        private double Compute(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }
        
        


        /// <summary>
        /// OLD METHODS USING SUBJECT OBSERVER PATTERN NOW
        /// </summary>
        /// <param name="currentEvent"></param>
        /// <param name="currentEntity"></param>
        /// <returns></returns>
        
        //public void Update() 
        //{
        //    ///
        //    /// Display the calender in realtime
        //    ///
        //    //Update(dgvCalender);
            
        //    ///
        //    /// Show entities in the queues
        //    ///
        //    //Update(dgvOtherQueue, ECallType.OTHER);
        //    //Update(dgvCarStereoQueue, ECallType.CAR_STEREO);
        //}

        //private void Update(DataGridView dataGridView) 
        //{
        //    // Clear the data grid view rows
        //    dataGridView.Rows.Clear();

        //    // Add row data
        //    for (int i = 0; i < calender.events.Count; i++)
        //    {
        //        Event currentEvent = calender.events[i];
        //        // Get events entity
        //        Entity eventEntity = currentEvent.CurrentEntity;

        //        // Get event row data
        //        //string[] rowData = getRowData(currentEvent, eventEntity);

        //        // Add new row
        //        //dataGridView.Rows.Add(rowData);
        //    }

        //    // Refresh the data grid view
        //    dataGridView.Refresh();
        //}

        //private void Update(DataGridView dataGridView, ECallType callType) 
        //{
        //    // Clear the items in the listbox
        //    dataGridView.Rows.Clear();

        //    // Get the entityData from the calltype queue
        //    List<string[]> entityData = resourceMananger.GetQueueEntityData(callType);

        //    // Add new row
        //    foreach (String[] data in entityData) 
        //        dataGridView.Rows.Add(data);

        //    // Refresh the listbox
        //    dataGridView.Refresh();
        //}

        //public void ComputeStatistics() 
        //{
        //    ///
        //    /// Update Entity Statistics 
        //    ///

        //    // Clear the display
        //    //dgvStatistics.Rows.Clear();

        //    // Loop through all the enititys that left the system
        //    foreach (Entity entity in leavingEntities)
        //    {
                

        //        // Display the entities that left the system
        //        //string[] entityData = getRowData(null, entity);
        //        //dgvStatistics.Rows.Add(entityData);

                

                
        //    }

            
            
        //}

        
    }
}
