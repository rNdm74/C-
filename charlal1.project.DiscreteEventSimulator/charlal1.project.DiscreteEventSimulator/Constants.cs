using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    enum ECallType { CAR_STEREO, OTHER }
    enum EEventType { ARRIVAL, SWITCH_COMPLETE, PROCESSING_COMPLETE, END_SIMULATION }
    
    public static class Global 
    {
        public static DateTime Clock { get; set; }
    }

    public static class Constants
    {
        //
        public const int FIRST_IN_QUEUE              = 0;
        public const int CALL_TYPE_PROBABILITY       = 4;

        // Simulation Constants
        public const int MAX_RESOURCES_OTHER         = 2;
        public const int MAX_RESOURCES_CAR_STEREO    = 1;
        public const int MAX_ON_HOLD                 = 10;
        public const int EXCESSIVE_WAIT_TIME         = 1;

        // Delay Constants
        public const double DELAY_ARRIVAL            = 0.33;
        public const double DELAY_IVR                = 0.3;
        public const int    DELAY_PROCESSING         = 2;

        // String outputs
        public const string ARRIVAL = "Arrival at call centre";
        public const string IVR = "Complete service IVR";
        public const string OTHER = "Complete service other";
        public const string STEREO = "Complete service car stereo";
        public const string END = "End replication";
    }
}
