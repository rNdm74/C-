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

        public double TimeBetweenArrivals() 
        {
            return Roll() * Constants.DELAY_ARRIVAL;
        }

        public double DelayAtIVR()
        {
            return Roll() * Constants.DELAY_IVR;
        }

        public double DelayCarStereo() 
        {
            return Roll() * Constants.DELAY_PROCESSING;
        }

        public double DelayOther() 
        {
            return Roll();
        }
    }
}
