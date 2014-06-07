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
        private int waitingAverageCount, waitingAverageCarStereoCount, waitingAverageOtherCount, systemAverageCount;

        private Calender calender                { get; set; }
        private ResourceManager resourceMananger { get; set; }



        //private List<Entity> leavingEntities;
        private List<IDisplay> displayList;
        
        public Statistics() 
        {
            this.displayList = new List<IDisplay>();
            //this.leavingEntities = new List<Entity>();

            waitingAverageCount = waitingAverageCarStereoCount = waitingAverageOtherCount = systemAverageCount = 0;

            // Set variables to 0
            //BusySignalCount = CallCompletion = ExcessiveWaitCount = ResourceUtilization = Iterations = ResourcesUsed = 0;
            //AverageWaitingTime = AverageSystemTime = AverageNumberWaiting = ResourseOtherWorkTime = ResourseCarStereoWorkTime = ResourseWorkTime = SystemTime = 0;
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
            
            UpdateResourceUtilization(e);
            
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
            Global.ResourseWorkTime += e.EndTime.Subtract(e.StartProcessingTime).TotalSeconds;
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
                    Global.ResourseOtherWorkTime += e.EndTime.Subtract(e.StartProcessingTime).TotalSeconds;
                    break;
                case ECallType.CAR_STEREO:
                    Global.ResourseCarStereoWorkTime += e.EndTime.Subtract(e.StartProcessingTime).TotalSeconds;
                    break;
	        }
        }


        

        


        private void UpdateAverageWaitingTime(double waitTime) 
        {
            // Running average of the wait time of entities
            //double waitTime = entity.EndTime.Subtract(entity.BeginWait).TotalMinutes;
            Global.AverageWaitingTime += Compute(waitTime, Global.AverageWaitingTime, waitingAverageCount);
        }

        private void UpdateAverageNumberWaiting(ECallType? callType) 
        {
            // Running average of entities waiting
            Global.AverageNumberWaiting++;
            Global.AverageNumberWaiting += Compute(1, Global.AverageNumberWaiting, ++waitingAverageCount);

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

        private void UpdateExcessiveWaiting(ECallType? callType, double waitTime) 
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
            double sysTime = e.EndTime.Subtract(e.StartTime).TotalMinutes;

            Global.AverageSystemTime += Compute(sysTime, Global.AverageSystemTime, ++systemAverageCount);
        }

        private double Compute(double newValue, double avgValue, int count)
        {
            return (newValue - avgValue) / count;
        }        
    }
}
