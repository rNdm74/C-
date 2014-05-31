using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class QueueManager
    {
        List<Queue> simulatorQueues;

        public QueueManager() 
        {
            simulatorQueues = new List<Queue>();
            simulatorQueues.Add(new Queue(ECallType.OTHER));
            simulatorQueues.Add(new Queue(ECallType.CAR_STEREO));
        }

        public bool IsQueueEmpty(ECallType callType) 
        {
            Queue queue = simulatorQueues.Find(q => q.CallType == callType);

            return (queue.IsEmpty());
        }

        public bool IsSpaceInQueues() 
        {
            int total = 0;

            foreach (var queue in simulatorQueues)
	        {
                total += queue.Count();	 
	        }

            return (total < Constants.MAX_ON_HOLD);
        }

        public void AddEntity(Entity currentEntity) 
        {
            // Get the queue for the call type
            Queue queue = simulatorQueues.Find(q => q.CallType == currentEntity.CallType);
            // Add entitiy to queue
            queue.Add(currentEntity);
        }

        public Entity GetFirstInQueue(ECallType callType) 
        {
            Queue queue = simulatorQueues.Find(q => q.CallType == callType);
            return queue.First();
        }
    }
}
