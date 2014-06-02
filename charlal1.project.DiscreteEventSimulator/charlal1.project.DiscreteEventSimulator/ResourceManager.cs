using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{   
    class ResourceManager
    {
        private List<Resource> resources;
        private QueueManager queueManager;

        public ResourceManager() 
        {
            resources = new List<Resource>();
            queueManager = new QueueManager();

            for (int i = 0; i < Constants.MAX_RESOURCES_CAR_STEREO; i++)
                resources.Add(new Resource(ECallType.CAR_STEREO));

            for (int i = 0; i < Constants.MAX_RESOURCES_OTHER; i++)
                resources.Add(new Resource(ECallType.OTHER));
        }

        public List<string> GetQueueEntityIDs(ECallType callType) 
        {
            return queueManager.GetEntityIDsInQueue(callType);
        }

        public bool IsSpaceInQueues() 
        {
            // Returns true if there is space in all queues
            return queueManager.IsSpaceInAllQueues();
        }

        public bool IsQueueEmpty(ECallType calltype) 
        {
            // Returns true if the call type queue has no entities waiting
            return queueManager.IsQueueEmpty(calltype);
        }

        public Resource NextAvailableResource(ECallType? calltype)
        {
            // Returns a resource, of its a specific calltype and it must be free else return null
            Resource resource = resources.Find(r => (r.CallType == calltype && r.IsFree == true));

            return resource;
        }

        public void AddToQueue(Entity currentEntity) 
        {
            // Adds the current entity to a queue
            queueManager.AddEntity(currentEntity);
        }

        public Entity GetFirstInQueue(ECallType calltype) 
        {
            // Pops the first in the queue
            return queueManager.GetFirstInQueue(calltype);
        }
    }
}
