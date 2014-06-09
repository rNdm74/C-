using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Queue
    {
        public List<Entity> entityQueue;
        public ECallType CallType { get; set; }

        public Queue(ECallType callType) 
        {
            this.CallType = callType;

            this.entityQueue = new List<Entity>();
        }

        public void Add(Entity entityWaiting)
        {
            // Add entity to the queue
            entityQueue.Add(entityWaiting);
        }

        public List<string[]> GetEntityDataInQueue() 
        {
            // Create list of entity ids
            List<string[]> entityData = new List<string[]>();

            // Get all the ids of the entities in the queue
            foreach (Entity e in entityQueue) 
            {
                TimeSpan st = TimeSpan.FromSeconds(e.StartTime);
                TimeSpan wt = TimeSpan.FromSeconds(e.BeginWait);

                int stHours = st.Hours + (Global.START_SIMULATION_TIME / 100);
                int wtHours = wt.Hours + (Global.START_SIMULATION_TIME / 100);

                string entityID = e.ID.ToString();
                string eventType = "---";
                string eventTime = "---";
                string entityCallType = (e.CallType == null) ? "---" : e.CallType.ToString();
                string entityStartTime = (e.StartTime == 0) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", stHours, st.Minutes, st.Seconds);//(currentEntity.StartTime.ToString("yyyy").Equals("0001")) ? "---" : currentEntity.StartTime.ToShortTimeString();
                string entityBeginWait = (e.BeginWait == 0) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", wtHours, wt.Minutes, wt.Seconds);//(currentEntity.BeginWait.ToString("yyyy").Equals("0001")) ? "---" : currentEntity.BeginWait.ToShortTimeString();


                entityData.Add(new string[] { entityID, eventType, eventTime, entityCallType, entityStartTime, entityBeginWait });
            }
              
            // Return list
            return entityData;
        }

        public Entity GetFirstInQueue() 
        {
            // Pops the first in the queue
            Entity firstInQueue = entityQueue.First();
            // Removes it from the queue
            entityQueue.RemoveAt(0);

            return firstInQueue;
        }

        // Count method
        public int Count
        {
            get
            {
                return entityQueue.Count;
            }
        }

        public bool IsEmpty 
        {
            get
            {
                return (entityQueue.Count <= 0);
            }
        }
    }
}
