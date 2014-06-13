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
        private Calender calender;
        private ResourceManager resourceManager;
        private List<IDisplay> displayList;
        private StatisticsProcessor statisticsProcessor;
        
        public Statistics() 
        {
            this.displayList = new List<IDisplay>();
            this.statisticsProcessor = new StatisticsProcessor();
        }
        
        /// <summary>
        /// Adds a display to the list
        /// </summary>
        public void AddDisplay(IDisplay d)
        {
            displayList.Add(d);
        }

        /// <summary>
        /// Removes a display from the list
        /// </summary>
        public void RemoveDisplay(IDisplay d)
        {
            // Add error checking
            if(displayList.Contains(d))
                displayList.Remove(d);
        }

        /// <summary>
        /// Keeps the calender and resourcemanager lists up to date
        /// </summary>
        public void UpdateLists(Calender calender, ResourceManager resourceManager) 
        {
            this.calender = calender;
            this.resourceManager = resourceManager;
        }

        /// <summary>
        /// Update the observers and then tell them to draw 
        /// </summary>
        public void NotifyDisplays()
        {
            foreach (IDisplay currentDisplay in displayList)
            {
                currentDisplay.Update(calender, resourceManager, this);
                currentDisplay.Draw();
            }
        }
        
        /// <summary>
        /// Get all statistics form the entity
        /// </summary>
        public void UpdateEntityStatistics(Entity e)
        {
            statisticsProcessor.Update(e);
        }

        /// <summary>
        /// Return data to be exported in csv format
        /// </summary>
        public Dictionary<int, string> ExportCSVData
        {
            get
            {
                return statisticsProcessor.ExportCsvData;
            }
        }
    }

    class StatisticsProcessor
    {
        private int count;
        private int iterations;
        private Dictionary<int, string> exportCsvData;
        public Dictionary<int, string> ExportCsvData { get { return exportCsvData; } }
        
        public StatisticsProcessor() 
        {
            // Init
            this.count = 1;
            this.iterations = 0;
            this.exportCsvData = new Dictionary<int, string>();
        }

        /// <summary>
        /// Update the stats
        /// </summary>
        public void Update(Entity e) 
        {
            // Updats call completions of the simulation
            completions(e.CallType);

            // If the entity waited
            if (e.BeginWait != 0)
            {
                // Work out entity wait time
                int waitTime = (e.EndTime - e.BeginWait) / Constants.CONVERT_TO_SECONDS;

                // Update waiting averages
                averageWaitTime(waitTime);
                averageNumberWaiting(e.CallType);
                excessiveWaiting(e.CallType, waitTime);
            }

            // Update system time for all entities
            averageSystemTime(e);
            // Increments the resources work times
            resourceWorkTime(e);
            // Computes resources utilization
            resourceUtilization(e);
            // Increment count for averages
            count++;

            // Update data for csv export
            exportCsvData.Add(iterations, csvData);
            // Track system iterations
            iterations++;
        }

        /// <summary>
        /// Computes all call compleation stats
        /// </summary>
        private void completions(ECallType? callType)
        {
            // Update statistics of every enitiy leaving system
            Global.CallCompletion++;

            // Update individual completions
            switch (callType)
            {
                case ECallType.OTHER:
                    Global.CallCompletionType1++;
                    break;
                case ECallType.CAR_STEREO:
                    Global.CallCompletionType2++;
                    break;
            }
        }
        
        /// <summary>
        /// Computes the average time all entites waited
        /// </summary>
        private void averageWaitTime(int waitTime)
        {
            // Running average of the wait time of entities
            Global.AverageWaitingTime += computeAverage(waitTime, Global.AverageWaitingTime, count);
        }

        /// <summary>
        /// Computes the average number of entities that waited
        /// </summary>
        private void averageNumberWaiting(ECallType? callType)
        {
            // Running average of entities waiting
            Global.WaitCount++;
            Global.AverageNumberWaiting += computeAverage(Global.WaitCount, Global.AverageNumberWaiting, count);
                        
            switch (callType)
            {
                case ECallType.CAR_STEREO:
                    Global.WaitCountType2++;
                    Global.AverageNumberWaitingType2 += computeAverage(Global.WaitCountType2, Global.AverageNumberWaitingType2, count);
                    break;
                case ECallType.OTHER:
                    Global.WaitCountType1++;
                    Global.AverageNumberWaitingType1 += computeAverage(Global.WaitCountType1, Global.AverageNumberWaitingType1, count);
                    break;
            }
        }

        /// <summary>
        /// If the entity is waiting over 1 min, can be set by user
        /// </summary>
        private void excessiveWaiting(ECallType? callType, int waitTime)
        {
            // Work out if call had an excessive wait time
            if (waitTime > Global.ExcessiveWaitTime)
            {
                Global.ExcessiveWaitCount++;

                switch (callType)
                {
                    case ECallType.CAR_STEREO:
                        Global.ExcessiveWaitCountType2++;
                        break;
                    case ECallType.OTHER:
                        Global.ExcessiveWaitCountType1++;
                        break;
                }
            }
        }
        
        /// <summary>
        /// Computes the average time it takes for entity to traverse the system
        /// </summary>
        private void averageSystemTime(Entity e)
        {
            // Computes the time in seconds a entity moves through the simulation
            double systemTraversalTime = (e.EndTime - e.StartTime) / Constants.CONVERT_TO_SECONDS;

            // Average time entity takes to get through the system
            Global.AverageSystemTime += computeAverage(systemTraversalTime, Global.AverageSystemTime, count);
        }

        /// <summary>
        /// Computes all resources worktime for the entity
        /// </summary>
        private void resourceWorkTime(Entity e)
        {
            // Increments total resource worktime
            Global.ResourseTotalWorkTime += e.EndTime - e.StartProcessingTime;

            // Increments specific resouce worktime
            switch (e.CallType)
            {
                case ECallType.OTHER:
                    Global.ResourseType1TotalWorkTime += e.EndTime - e.StartProcessingTime;
                    break;
                case ECallType.CAR_STEREO:
                    Global.ResourseType2TotalWorkTime += e.EndTime - e.StartProcessingTime;
                    break;
            }
        }

        /// <summary>
        /// Computes all resource utilization
        /// </summary>
        private void resourceUtilization(Entity e)
        {
            // Utilization computation equations: 

            // Specific Utilzation = (Total time worked specific resource / Total number of specific resources) / Total time system run
            Global.ResourceType1Utilization = (Global.ResourseType1TotalWorkTime / Global.MaxResourcesType1) / Global.SystemTime;
            Global.ResourceType2Utilization = (Global.ResourseType2TotalWorkTime / Global.MaxResourcesType2) / Global.SystemTime;

            // Total Utilization = (Total time worked / Total number of all resources) / Total time system run
            Global.ResourceUtilization = (Global.ResourseTotalWorkTime / (Global.MaxResourcesType1 + Global.MaxResourcesType2)) / Global.SystemTime;
        }

        /// <summary>
        /// Compute the average, new data minus the current average devided by the count
        /// </summary>
        private double computeAverage(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }

        /// <summary>
        /// To string for all global statstical data, creates row of data for the CSV export
        /// </summary>
        private string csvData
        {
            get
            {
                return
                Global.BusySignalCount + "," +
                Global.CallCompletion + "," +
                Global.CallCompletionType1 + "," +
                Global.CallCompletionType2 + "," +
                Global.ExcessiveWaitCount + "," +
                Global.ExcessiveWaitCountType1 + "," +
                Global.ExcessiveWaitCountType2 + "," +
                Global.ResourceUtilization + "," +
                Global.ResourceType1Utilization + "," +
                Global.ResourceType2Utilization + "," +
                Global.ResourseType1TotalWorkTime + "," +
                Global.ResourseType2TotalWorkTime + "," +
                Global.ResourseTotalWorkTime + "," +
                Global.SystemTime + "," +
                Global.AverageNumberWaiting + "," +
                Global.AverageWaitingTime + "," +
                Global.AverageNumberWaitingType1 + "," +
                Global.AverageNumberWaitingType2 + "," +
                Global.AverageSystemTime;   
            }                     
        }
    }
}
