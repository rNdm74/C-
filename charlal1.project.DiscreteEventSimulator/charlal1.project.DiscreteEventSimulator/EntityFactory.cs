using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class EntityFactory
    {
        private int EntityID;
        private RandomNumberGenerator rGen;

        public EntityFactory(RandomNumberGenerator rGen) 
        {
            this.rGen = rGen;

            // On creation of factory IDs are reset to 1
            this.EntityID = 1;
        }

        public Entity CreateEntity(DateTime EventTime)
        {
            Entity newEntity = new Entity(EntityID);

            newEntity.CallType = (rGen.Roll() <= Constants.CALL_PROBABILITY) ? ECallType.CAR_STEREO : ECallType.OTHER;

            return newEntity;
        }
    }
}
