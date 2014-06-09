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

            //TimeSpan ts = new TimeSpan();
            
        }

        public int Roll
        {
            get
            {
                int d1 = rGen.Next(1, 7);
                int d2 = rGen.Next(1, 7);

                return d1 + d2;
            }
        }

        public int TimeBetweenArrivals 
        {
            get
            {
                return (int) (Roll * Global.DELAY_ARRIVAL) * Constants.SECONDS_TO_MINUTES;
            }
        }

        public int DelayAtSwitch
        {
            get
            {
                return (int)(Roll * Global.DELAY_SWITCH) * Constants.SECONDS_TO_MINUTES;
            }
        }

        public int DelayCarStereo 
        {
            get
            {
                return (int)(Roll * Global.DELAY_PROCESSING) * Constants.SECONDS_TO_MINUTES;
            }
        }

        public int DelayOther
        {
            get
            {
                return Roll * Constants.SECONDS_TO_MINUTES;
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
                if(Roll <= Constants.CALL_TYPE_PROBABILITY)
                    return ECallType.CAR_STEREO;
                else
                    return ECallType.OTHER;
            }
        }
    }
}
