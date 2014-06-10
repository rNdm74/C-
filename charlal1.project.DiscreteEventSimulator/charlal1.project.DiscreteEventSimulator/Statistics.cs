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
        private int count = 0;

        private int iterations, averageWaitingTimeCount, averageNumberWaitingCount, waitingAverageCarStereoCount, waitingAverageOtherCount, systemAverageCount;

        private Calender calender;
        private ResourceManager resourceMananger;

        public Dictionary<int, string> CsvData   { get; set; }

        private List<IDisplay> displayList;
        
        public Statistics() 
        {
            this.CsvData = new Dictionary<int,string>();
            this.displayList = new List<IDisplay>();
            iterations = averageWaitingTimeCount = averageNumberWaitingCount = waitingAverageCarStereoCount = waitingAverageOtherCount = systemAverageCount = 0;
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


        public void UpdateEntityStatistics(Entity e)
        {
            // Update statistics of enitiy leaving system
            Global.CallCompletion++;

            UpdateCompletions(e.CallType);

            // If the entity waited
            if(e.BeginWait != 0)
            {
                // Work out entity wait time
                int waitTime = (e.EndTime - e.BeginWait) / Constants.SECONDS_TO_MINUTES;

                // Update waiting averages
                UpdateAverageNumberWaiting(e.CallType);
                UpdateAverageWaitingTime(waitTime);
                UpdateExcessiveWaiting(e.CallType, waitTime);
                //count+
            }

            // Update system time for all entities
            UpdateSystemTime(e);
            
            UpdateResourceUtilization(e);

            UpdateCSVData();
        }

        public void UpdateCompletions(ECallType? callType)
        {
            switch (callType)
            {
                case ECallType.OTHER:
                    Global.CallCompletionOther++;
                    break;
                case ECallType.CAR_STEREO:
                    Global.CallCompletionCarStereo++;
                    break;
            }
        }

        public void UpdateResourceUtilization(Entity e) 
        {
            Global.ResourseWorkTime += e.EndTime - e.StartProcessingTime;
            updateWorkTime(e);
            Global.ResourceOtherUtilization = (Global.ResourseOtherWorkTime / Global.MAX_RESOURCES_OTHER) / Global.SystemTime;
            Global.ResourceCarStereoUtilization = (Global.ResourseCarStereoWorkTime / Global.MAX_RESOURCES_CAR_STEREO) / Global.SystemTime;
            Global.ResourceUtilization = (Global.ResourseWorkTime / (Global.MAX_RESOURCES_OTHER + Global.MAX_RESOURCES_CAR_STEREO)) / Global.SystemTime;
        }

        private void updateWorkTime(Entity e)
        {
            switch (e.CallType)
	        {
		        case ECallType.OTHER:
                    Global.ResourseOtherWorkTime += e.EndTime - e.StartProcessingTime;
                    break;
                case ECallType.CAR_STEREO:
                    Global.ResourseCarStereoWorkTime += e.EndTime - e.StartProcessingTime;
                    break;
	        }
        }

        private void UpdateAverageWaitingTime(int waitTime) 
        {
            // Running average of the wait time of entities
            //double waitTime = entity.EndTime.Subtract(entity.BeginWait).TotalMinutes;
            Global.AverageWaitingTime += Compute(waitTime, Global.AverageWaitingTime, ++averageWaitingTimeCount);
        }

        private void UpdateAverageNumberWaiting(ECallType? callType) 
        {
            // Running average of entities waiting
            Global.AverageNumberWaiting++;
            Global.AverageNumberWaiting += Compute(1, Global.AverageNumberWaiting, ++averageNumberWaitingCount);

            // Increment the waiting average count
            //waitingAverageCount++;

            switch (callType)
            {
                case ECallType.CAR_STEREO:
                    Global.AverageNumberWaitingCarStereo++;
                    Global.AverageNumberWaitingCarStereo += Compute(1, Global.AverageNumberWaitingCarStereo, ++waitingAverageCarStereoCount);
                    break;
                case ECallType.OTHER:
                    Global.AverageNumberWaitingOther++;
                    Global.AverageNumberWaitingOther += Compute(1, Global.AverageNumberWaitingOther, ++waitingAverageOtherCount);
                    break;
            }
        }

        private void UpdateExcessiveWaiting(ECallType? callType, int waitTime) 
        {
            // Work out if call had an excessive wait time
            if (waitTime > Global.EXCESSIVE_WAIT_TIME)
            {
                switch (callType)
                {
                    case ECallType.CAR_STEREO:
                        Global.ExcessiveWaitCountCarStereo++;
                        break;
                    case ECallType.OTHER:
                        Global.ExcessiveWaitCountOther++;
                        break;
                }

                Global.ExcessiveWaitCount++;
            }
        }

        private void UpdateSystemTime(Entity e) 
        {
            // Average time entity takes to get through the system
            double sysTime = (e.EndTime - e.StartTime) / Constants.SECONDS_TO_MINUTES;

            Global.AverageSystemTime += Compute(sysTime, Global.AverageSystemTime, ++systemAverageCount);
        }

        private double Compute(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }       
 
        private void UpdateCSVData()
        {
            string data = 
            Global.BusySignalCount + "," +
            Global.CallCompletion + "," +
            Global.CallCompletionOther + "," +
            Global.CallCompletionCarStereo + "," +
            Global.ExcessiveWaitCount + "," +
            Global.ExcessiveWaitCountOther + "," +
            Global.ExcessiveWaitCountCarStereo + "," +
            Global.ResourceUtilization + "," +
            Global.ResourceOtherUtilization + "," +
            Global.ResourceCarStereoUtilization + "," +
            Global.ResourseOtherWorkTime + "," +
            Global.ResourseCarStereoWorkTime + "," +
            Global.ResourseWorkTime + "," +
            Global.SystemTime + "," +
            Global.AverageNumberWaiting + "," +
            Global.AverageWaitingTime + "," +
            Global.AverageNumberWaitingOther + "," +
            Global.AverageNumberWaitingCarStereo + "," +
            Global.AverageSystemTime;

            CsvData.Add(iterations, data);

            iterations++;
        }
    }
}
