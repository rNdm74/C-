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

        /// <summary>
        /// Returns the result of two rolls of a dice
        /// </summary>
        private int rollDice()
        {
            int d1 = rGen.Next(1, 7);
            int d2 = rGen.Next(1, 7);

            return d1 + d2;
        }

        /// <summary>
        /// Calculates the delay time and returns it in integer format
        /// </summary>
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

        /// <summary>
        /// Get the time between entity arrivals
        /// </summary>
        public int TimeBetweenArrivals 
        {
            get
            {   
                return delayTime(Global.DelayArrival);
            }
        }

        /// <summary>
        /// Get the delay the entity is at the switch
        /// </summary>
        public int DelayAtSwitch
        {
            get
            {
                return delayTime(Global.DelaySwitch);
            }
        }

        /// <summary>
        /// Get the delay the entity is processed by the car stereo resource
        /// </summary>
        public int DelayCarStereo 
        {
            get
            {
                return delayTime(Global.DelayProcessing);
            }
        }

        /// <summary>
        /// Get the delay the entity is processed by the other resource
        /// </summary>
        public int DelayOther
        {
            get
            {
                return delayTime(1); // 1 meaning no value applied to the roll
            }
        }

        /// <summary>
        /// Return the event time depending on callType
        /// </summary>
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

        /// <summary>
        /// Return a call type effected by probability
        /// </summary>
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
