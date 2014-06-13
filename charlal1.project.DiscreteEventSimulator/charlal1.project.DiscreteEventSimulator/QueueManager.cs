using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class QueueManager
    {
        private List<Queue> simulatorQueues;

        public QueueManager() 
        {
            simulatorQueues = new List<Queue>();
            simulatorQueues.Add(new Queue(ECallType.OTHER));
            simulatorQueues.Add(new Queue(ECallType.CAR_STEREO));
        }

        /// <summary>
        /// Returns the data in a queue based on the calltyped
        /// </summary>
        public List<string[]> GetEntityDataInQueue(ECallType callType) 
        {
            // Get the queue for the call type
            Queue queue = simulatorQueues.Find(q => q.CallType == callType);
            return queue.GetEntityDataInQueue();
        }
        
        /// <summary>
        /// Finds the appropriate queue and returns if it is empty
        /// </summary>
        public bool IsQueueEmpty(ECallType callType) 
        {
            // Get the queue for the call type
            Queue queue = simulatorQueues.Find(q => q.CallType == callType);
            return queue.IsEmpty;
        }

        /// <summary>
        /// Counts all entities in all queues and returns if the is space across available queues 
        /// </summary>
        public bool IsSpaceInAllQueues() 
        {
            int total = 0;

            // Get the count from each queue  increment total
            foreach (Queue queue in simulatorQueues)
                total += queue.Count;

            // Return if the total is less than the max on hold limit
            return (total < Global.MaxOnHold);
        }

        /// <summary>
        /// Finds the appropriate queue and adds the entity
        /// </summary>
        public void AddEntity(Entity currentEntity) 
        {
            // Get the queue for the call type
            Queue queue = simulatorQueues.Find(q => q.CallType == currentEntity.CallType);

            // Add entitiy to queue
            queue.Add(currentEntity);
        }

        public Entity GetFirstInQueue(ECallType callType) 
        {
            // Gets the queue for the call type
            Queue queue = simulatorQueues.Find(q => q.CallType == callType);

            return queue.GetFirstInQueue();
        }
    }
}
