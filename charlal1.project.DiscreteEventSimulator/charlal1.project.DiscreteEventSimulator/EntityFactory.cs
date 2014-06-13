using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class EntityFactory
    {
        private int EntityID;

        public EntityFactory() 
        {
            // On creation of factory IDs are reset to 1
            this.EntityID = 0;
        }

        /// <summary>
        /// Returns a new entity with a unique ID
        /// </summary>
        public Entity CreateEntity()
        {
            return new Entity(++EntityID);;
        }
    }
}
