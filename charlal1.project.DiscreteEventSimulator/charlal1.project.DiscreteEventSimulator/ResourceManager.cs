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

            for (int i = 0; i < Constants.MAX_RESOURCES_CAR_STEREO; i++)
            {
                resources.Add(new Resource(ECallType.CAR_STEREO));
            }

            for (int i = 0; i < Constants.MAX_RESOURCES_OTHER; i++)
            {
                resources.Add(new Resource(ECallType.OTHER));
            }

            queueManager = new QueueManager();
        }

        public bool IsSpaceInQueues() 
        {
            return queueManager.IsSpaceInQueues();
        }

        public bool IsQueueEmpty(ECallType calltype) 
        {
            return queueManager.IsQueueEmpty(calltype);
        }

        public Resource NextAvailableResource()
        {
            Resource resource = resources.Find(r => r.IsFree == true);
            return resource;
        }

        public void AddToQueue(Entity currentEntity) 
        {
            if (queueManager.IsSpaceInQueues()) 
            {
                queueManager.AddEntity(currentEntity);
            }
        }

        public Entity GetNextEntityInQueue(ECallType calltype) 
        {
            return queueManager.GetFirstInQueue(calltype);
        }
    }
}
