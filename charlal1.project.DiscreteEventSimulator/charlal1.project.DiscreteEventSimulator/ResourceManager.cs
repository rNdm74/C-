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

            for (int i = 0; i < Global.MaxResourcesType2; i++)
                resources.Add(new Resource(ECallType.CAR_STEREO));

            for (int i = 0; i < Global.MaxResourcesType1; i++)
                resources.Add(new Resource(ECallType.OTHER));
        }

        public List<string[]> GetQueueEntityData(ECallType callType) 
        {
            return queueManager.GetEntityDataInQueue(callType);
        }

        public bool IsSpaceInQueues 
        {
            get
            {
                // Returns true if there is space in all queues
                return queueManager.IsSpaceInAllQueues();
            }
        }

        public bool IsQueueEmpty(ECallType calltype) 
        {
            // Returns true if the call type queue has no entities waiting
            return queueManager.IsQueueEmpty(calltype);
        }

        public Resource NextAvailableResource(ECallType? calltype)
        {
            // Returns a resource, of its a specific calltype and it must be free else return null
            return resources.Find(r => (r.CallType == calltype && r.IsFree == true));
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
