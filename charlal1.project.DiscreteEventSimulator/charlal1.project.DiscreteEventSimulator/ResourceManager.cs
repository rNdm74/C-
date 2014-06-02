using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{   
    class ResourceManager
    {
        private List<Resource> resources;
        public QueueManager queueManager;
        public double ResourcesWorkTime;

        public ResourceManager() 
        {
            resources = new List<Resource>();

            for (int i = 0; i < Constants.MAX_RESOURCES_CAR_STEREO; i++)
            {
                resources.Add(new Resource(ECallType.CAR_STEREO));
            }

            for (int i = 0; i < Constants.MAX_RESOURCES_OTHER; i++)
            {
                resources.Add(new Resource(ECallType.OTHER));
            }

            queueManager = new QueueManager();

            ResourcesWorkTime = 0;
        }

        public void AddResourceWorkTime() 
        {

        }

        public bool IsSpaceInQueues() 
        {
            return queueManager.IsSpaceInQueues();
        }

        public bool IsQueueEmpty(ECallType calltype) 
        {
            return queueManager.IsQueueEmpty(calltype);
        }

        public Resource NextAvailableResource(ECallType? calltype)
        {
            Resource resource = resources.Find(r => (r.CallType == calltype && r.IsFree == true));
            return resource;
        }

        public void AddToQueue(Entity currentEntity) 
        {
            if (queueManager.IsSpaceInQueues()) 
            {
                queueManager.AddEntity(currentEntity);
            }
        }

        public Entity GetFirstInQueue(ECallType calltype) 
        {
            return queueManager.GetFirstInQueue(calltype);
        }
    }
}
