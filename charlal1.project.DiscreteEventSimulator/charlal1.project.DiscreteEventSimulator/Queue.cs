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
            entityQueue.Add(entityWaiting);
        }

        public Entity GetFirstInQueue() 
        {
            Entity firstInQueue = entityQueue.First();
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
