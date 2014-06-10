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
        public Dictionary<int, string> CsvData { get; set; }

        private Calender calender;
        private ResourceManager resourceMananger;
        private List<IDisplay> displayList;
        private Update update;
        private int iterations;
        
        public Statistics() 
        {
            this.CsvData = new Dictionary<int,string>();
            this.displayList = new List<IDisplay>();
            this.update = new Update();
            this.iterations = 0;
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
            update.Completions(e.CallType);

            // If the entity waited
            if(e.BeginWait != 0)
            {
                // Work out entity wait time
                int waitTime = (e.EndTime - e.BeginWait) / Constants.SECONDS_TO_MINUTES;

                // Update waiting averages
                update.AverageWaitTime(waitTime);
                update.AverageNumberWaiting(e.CallType);                
                update.ExcessiveWaiting(e.CallType, waitTime);                
            }

            // Update system time for all entities
            update.AverageSystemTime(e);

            //
            update.UpdateWorkTime(e);
            //
            update.ResourceUtilization(e);
            //
            update.Count++;

            // Update data for csv export
            CsvData.Add(iterations, update.CSVData);

            // Track system iterations
            iterations++;
        }              
    }

    class Update
    {
        public int Count { get; set; }
        
        public Update() 
        {
            // Init
            Count = 1;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callType"></param>
        public void Completions(ECallType? callType)
        {
            // Update statistics of enitiy leaving system
            Global.CallCompletion++;

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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waitTime"></param>
        public void AverageWaitTime(int waitTime)
        {
            // Running average of the wait time of entities
            Global.AverageWaitingTime += Compute(waitTime, Global.AverageWaitingTime, Count);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callType"></param>
        public void AverageNumberWaiting(ECallType? callType)
        {
            // Running average of entities waiting
            Global.WaitCount++;
            Global.AverageNumberWaiting += Compute(Global.WaitCount, Global.AverageNumberWaiting, Count);
                        
            switch (callType)
            {
                case ECallType.CAR_STEREO:
                    Global.WaitCountCarStereo++;
                    Global.AverageNumberWaitingCarStereo += Compute(Global.WaitCountCarStereo, Global.AverageNumberWaitingCarStereo, Count);
                    break;
                case ECallType.OTHER:
                    Global.WaitCountOther++;
                    Global.AverageNumberWaitingOther += Compute(Global.WaitCountOther, Global.AverageNumberWaitingOther, Count);
                    break;
            }
        }

        /// <summary>
        /// If the entity is waiting over 1 min, can be set by user
        /// </summary>
        /// <param name="callType"></param>
        /// <param name="waitTime"></param>
        public void ExcessiveWaiting(ECallType? callType, int waitTime)
        {
            // Work out if call had an excessive wait time
            if (waitTime > Global.EXCESSIVE_WAIT_TIME)
            {
                Global.ExcessiveWaitCount++;

                switch (callType)
                {
                    case ECallType.CAR_STEREO:
                        Global.ExcessiveWaitCountCarStereo++;
                        break;
                    case ECallType.OTHER:
                        Global.ExcessiveWaitCountOther++;
                        break;
                }
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void AverageSystemTime(Entity e)
        {
            // Average time entity takes to get through the system
            double sysTime = (e.EndTime - e.StartTime) / Constants.SECONDS_TO_MINUTES;

            Global.AverageSystemTime += Compute(sysTime, Global.AverageSystemTime, Count);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void UpdateWorkTime(Entity e)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void ResourceUtilization(Entity e)
        {
            Global.ResourseWorkTime += e.EndTime - e.StartProcessingTime;
            //UpdateWorkTime(e);
            Global.ResourceOtherUtilization = (Global.ResourseOtherWorkTime / Global.MAX_RESOURCES_OTHER) / Global.SystemTime;
            Global.ResourceCarStereoUtilization = (Global.ResourseCarStereoWorkTime / Global.MAX_RESOURCES_CAR_STEREO) / Global.SystemTime;
            Global.ResourceUtilization = (Global.ResourseWorkTime / (Global.MAX_RESOURCES_OTHER + Global.MAX_RESOURCES_CAR_STEREO)) / Global.SystemTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newValue"></param>
        /// <param name="avgValue"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private double Compute(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CSVData
        {
            get
            {
                return
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
            }                     
        }
    }
}
