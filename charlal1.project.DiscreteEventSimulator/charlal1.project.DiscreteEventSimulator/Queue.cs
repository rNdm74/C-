using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Queue
    {
        private List<Entity> EntityQueue;
        private EQueueType QueueType;

        public Queue(EQueueType QueueType) 
        {
            this.QueueType = QueueType;

            this.EntityQueue = new List<Entity>();
        }

        public void Add(Entity entityWaiting)
        {
            EntityQueue.Add(entityWaiting);
        }

        public Entity Pop() 
        {
            return EntityQueue.First();
        }

        // Count method


    }
}
