﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    enum ECallType { CAR_STEREO, OTHER }
    enum EQueueType { CAR_STEREO, OTHER, IVR }
    enum EEventType { ARRIVAL, SWITCH_COMPLETE, QUEUE, PROCESSING_COMPLETE, FINISHED, END_SIMULATION }

    public static class Global 
    {
        public static DateTime Clock;
    }

    public static class Constants
    {
        public const int FIRST_IN_QUEUE              = 0;
        public const int MAX_RESOURCES               = 0;
        public const int MAX_ON_HOLD                 = 10;
        public const int MAX_NO_CALLS                = 0;
        public const double DELAY_ARRIVAL            = 0.33;
        public const double DELAY_IVR                = 0.3;
        public const int DELAY_PROCESSING            = 2;
        public const int CALL_PROBABILITY            = 4;

        public const string ARRIVAL = "Arrival at call centre";
        public const string IVR = "Complete service IVR";
        public const string OTHER = "Complete service other";
        public const string STEREO = "Complete service car stereo";
        public const string END = "End replication";


        //public const DateTime END_SIMULATION_TIME    = DateTime.Now.AddMinutes(1);
    }
}
