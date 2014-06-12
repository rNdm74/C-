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

        private int rollDice()
        {
            int d1 = rGen.Next(1, 7);
            int d2 = rGen.Next(1, 7);

            return d1 + d2;
        }

        private int delayTime(double delay) 
        {
            // Get dice roll
            int roll = rollDice();
            // Get factor based on delay const
            double factor = roll * delay;
            // Convert to seconds from minutes
            double delaySeconds = factor * Constants.CONVERT_TO_SECONDS;
            // Convert to integer for Global.Clock
            int result = (int)Math.Ceiling(delaySeconds);

            return result;
        }

        public int TimeBetweenArrivals 
        {
            get
            {   
                return delayTime(Global.DelayArrival);
            }
        }

        public int DelayAtSwitch
        {
            get
            {
                return delayTime(Global.DelaySwitch);
            }
        }

        public int DelayCarStereo 
        {
            get
            {
                return delayTime(Global.DelayProcessing);
            }
        }

        public int DelayOther
        {
            get
            {
                return delayTime(1);
            }
        }

        public int NextEventTime(ECallType? callType) 
        {
            switch (callType)
            {
                case ECallType.CAR_STEREO:
                    return DelayCarStereo;
                case ECallType.OTHER:
                    return DelayOther;
                default:
                    return DelayAtSwitch;
            }
        }

        public ECallType GetCallType
        {
            get
            {
                int roll = rollDice();

                if (roll <= Global.CallTypeProbability)
                    return ECallType.CAR_STEREO;
                else
                    return ECallType.OTHER;
            }
        }
    }
}
