using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class RandomNumberGenerator
    {
        private Random rGen;

        public RandomNumberGenerator()
        {
            rGen = new Random();
        }

        public int Roll()
        {
            int d1 = rGen.Next(1, 7);
            int d2 = rGen.Next(1, 7);

            return d1 + d2;
        }

        public double TimeBetweenArrivals 
        {
            get
            {
                return Roll() * Global.DELAY_ARRIVAL;
            }
        }

        public double DelayAtSwitch
        {
            get
            {
                return Roll() * Global.DELAY_SWITCH;
            }
        }

        public double DelayCarStereo() 
        {
            return Roll() * Global.DELAY_PROCESSING;
        }

        public double DelayOther() 
        {
            return Roll();
        }
    }
}
