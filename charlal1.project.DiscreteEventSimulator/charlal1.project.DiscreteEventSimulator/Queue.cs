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

        public List<string> GetEntityIDsInQueue() 
        {
            // Create list of entity ids
            List<string> entityIDs = new List<string>();

            // Get all the ids of the entities in the queue
            foreach (Entity e in entityQueue)
                entityIDs.Add(e.ID.ToString());

            // Return list
            return entityIDs;
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
        public int Count() 
        {
            return entityQueue.Count;
        }

        public bool IsEmpty() 
        {
            return (entityQueue.Count <= 0);
        }
    }
}
