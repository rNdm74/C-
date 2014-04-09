using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetrolBot
{
    class Bots : SimulationObject
    {
        public Bots(Random rGen, int worldWidth, int worldHeight)
            : base(rGen, worldWidth, worldHeight)
        { 
        }



        public override void UpdateState()
        {
            switch (state)
            {
                case EObjectState.MOVING:
                    break;
                case EObjectState.WAITING:
                    break;
                case EObjectState.REFUELING:
                    break;
                default:
                    break;
            }
        }

        public override void PerformAction()
        {
            switch (state)
            {
                case EObjectState.MOVING:
                    break;
                case EObjectState.WAITING:
                    break;
                case EObjectState.REFUELING:
                    break;
                default:
                    break;
            }
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
