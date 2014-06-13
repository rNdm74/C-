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

            // Setup resources
            for (int i = 0; i < Global.MaxResourcesType1; i++)
                resources.Add(new Resource(ECallType.OTHER));
            for (int i = 0; i < Global.MaxResourcesType2; i++)
                resources.Add(new Resource(ECallType.CAR_STEREO));
        }

        /// <summary>
        /// Gets a formatted list of data from the queue
        /// </summary>
        public List<string[]> GetQueueEntityData(ECallType callType) 
        {
            return queueManager.GetEntityDataInQueue(callType);
        }

        /// <summary>
        /// Returns true if there is space in all queues
        /// </summary>
        public bool IsSpaceInQueues 
        {
            get
            {
                return queueManager.IsSpaceInAllQueues();
            }
        }

        /// <summary>
        /// Returns true if the call type queue has no entities waiting
        /// </summary>
        public bool IsQueueEmpty(ECallType calltype) 
        {
            return queueManager.IsQueueEmpty(calltype);
        }

        /// <summary>
        /// Returns the next available resource
        /// </summary>
        public Resource NextAvailableResource(ECallType? calltype)
        {
            // Specific calltype and resource must be free else will return null 
            return resources.Find(r => (r.CallType == calltype && r.IsFree == true));
        }

        /// <summary>
        /// Adds the current entity to a queue 
        /// </summary>
        public void AddToQueue(Entity currentEntity) 
        {   
            queueManager.AddEntity(currentEntity);
        }

        /// <summary>
        /// Pops the first in the queue 
        /// </summary>
        public Entity GetFirstInQueue(ECallType calltype) 
        {
            return queueManager.GetFirstInQueue(calltype);
        }
    }
}
