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

        /// <summary>
        /// Add entity to the queue
        /// </summary>
        public void Add(Entity entityWaiting)
        {
            // Add entity to the queue
            entityQueue.Add(entityWaiting);
        }

        /// <summary>
        /// Returns a toString list of all the entities in the queue
        /// </summary>
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

        /// <summary>
        /// Pops the first in the queue
        /// </summary>
        public Entity GetFirstInQueue() 
        {
            // Pops the first in the queue
            Entity firstInQueue = entityQueue.First();

            // Removes it from the queue
            entityQueue.RemoveAt(0);

            return firstInQueue;
        }

        /// <summary>
        /// Get the count of the queue
        /// </summary>
        public int Count
        {
            get
            {
                return entityQueue.Count;
            }
        }

        /// <summary>
        /// Returns if the queue is empty
        /// </summary>
        public bool IsEmpty 
        {
            get
            {
                return (entityQueue.Count <= 0);
            }
        }
    }
}
