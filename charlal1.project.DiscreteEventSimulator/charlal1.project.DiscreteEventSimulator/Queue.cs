using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Queue
    {
        private List<Entity> entityQueue;
        private ECallType callType;
        public ECallType CallType { get { return callType; } }
        

        public Queue(ECallType callType) 
        {
            this.callType = callType;
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
                entityData.Add(e.ToString());
              
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
