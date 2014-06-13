using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Entity
    {
        private int Id;
        public int ID                   { get { return Id; } }

        public Resource AssignResource  { get; set; }
        public ECallType? CallType      { get; set; }
        public int StartTime            { get; set; }
        public int BeginWait            { get; set; }
        public int StartProcessingTime  { get; set; }
        public int EndTime              { get; set; }

        public Entity(int Id) 
        {
            this.Id = Id;
        }

        /// <summary>
        /// Returns a string array of all the entities data
        /// </summary>
        public string[] ToString() 
        {
            // Work out time from seconds
            TimeSpan st = TimeSpan.FromSeconds(StartTime);
            TimeSpan wt = TimeSpan.FromSeconds(BeginWait);

            // Format the hours 
            int stHours = st.Hours + (Global.StartSimulationTime / Constants.DATE_TIME_FACTOR);
            int wtHours = wt.Hours + (Global.StartSimulationTime / Constants.DATE_TIME_FACTOR);

            // Setup strings for formatting
            string entityID = ID.ToString();
            string eventType = "---";
            string eventTime = "---";

            // When a calltype has been assigned
            string entityCallType = (CallType == null) ? "---" : CallType.ToString(); 

            // When no time has been set
            string entityStartTime = (StartTime == 0) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", stHours, st.Minutes, st.Seconds);
            string entityBeginWait = (BeginWait == 0) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", wtHours, wt.Minutes, wt.Seconds);

            // Return list for datagridviews
            return new string[] { entityID, eventType, eventTime, entityCallType, entityStartTime, entityBeginWait };
        }
    }
}
