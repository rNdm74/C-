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

        public ECallType? CallType      { get; set; }
        public int StartTime            { get; set; }
        public int BeginWait            { get; set; }
        public int StartProcessingTime  { get; set; }
        public int EndTime              { get; set; }
        public Resource AssignResource  { get; set; }
        
        public Entity(int Id) 
        {
            this.Id = Id;
        }

        public string[] ToString() 
        {
            TimeSpan st = TimeSpan.FromSeconds(StartTime);
            TimeSpan wt = TimeSpan.FromSeconds(BeginWait);

            int stHours = st.Hours + (Global.StartSimulationTime / Constants.DATE_TIME_FACTOR);
            int wtHours = wt.Hours + (Global.StartSimulationTime / Constants.DATE_TIME_FACTOR);

            string entityID = ID.ToString();
            string eventType = "---";
            string eventTime = "---";
            string entityCallType = (CallType == null) ? "---" : CallType.ToString();
            string entityStartTime = (StartTime == 0) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", stHours, st.Minutes, st.Seconds);
            string entityBeginWait = (BeginWait == 0) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", wtHours, wt.Minutes, wt.Seconds);

            return new string[] { entityID, eventType, eventTime, entityCallType, entityStartTime, entityBeginWait };
        }
    }
}
