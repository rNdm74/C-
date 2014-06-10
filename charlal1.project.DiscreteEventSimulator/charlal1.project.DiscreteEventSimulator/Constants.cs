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
        public static int CLOCK                             { get; set; }
        public static int SIMULATION_SPEED                  { get; set; }

        // Simulation
        public static int START_SIMULATION_TIME             { get; set; }
        public static int END_SIMULATION_TIME               { get; set; }
        public static int MAX_RESOURCES_OTHER               { get; set; }
        public static int MAX_RESOURCES_CAR_STEREO          { get; set; }
        public static int MAX_ON_HOLD                       { get; set; }
        public static int EXCESSIVE_WAIT_TIME               { get; set; }

        // Delay
        public static double DELAY_ARRIVAL                  { get; set; }
        public static double DELAY_SWITCH                   { get; set; }
        public static double DELAY_PROCESSING               { get; set; }

        // Statistics
        public static int Iterations                        { get; set; }
        public static int ResourcesUsed                     { get; set; }

        public static int BusySignalCount                   { get; set; }
        public static int CallCompletion                    { get; set; }
        public static int CallCompletionOther               { get; set; }
        public static int CallCompletionCarStereo           { get; set; }
        public static int ExcessiveWaitCount                { get; set; }
        public static int ExcessiveWaitCountOther           { get; set; }
        public static int ExcessiveWaitCountCarStereo       { get; set; }

        public static double ResourceUtilization            { get; set; }
        public static double ResourceOtherUtilization       { get; set; }
        public static double ResourceCarStereoUtilization   { get; set; }
        public static double ResourseOtherWorkTime          { get; set; }
        public static double ResourseCarStereoWorkTime      { get; set; }
        public static double ResourseWorkTime               { get; set; }
        public static double SystemTime                     { get; set; }

        public static double AverageNumberWaiting           { get; set; }
        public static double AverageWaitingTime             { get; set; }
        public static double AverageNumberWaitingOther      { get; set; }
        public static double AverageNumberWaitingCarStereo  { get; set; }
        public static double AverageSystemTime              { get; set; }
    }

    public static class Constants
    {
        //
        public const int FIRST_IN_QUEUE              = 0;
        public const int EVENT_ENTITY_POS            = 0;
        public const int EVENT_TYPE_POS              = 1;
        public const int EVENT_CALL_TYPE_POS         = 3;
        public const int CALL_TYPE_PROBABILITY       = 4;
        public const int SECONDS_TO_MINUTES          = 60;
        // Simulation Constants
        //public const int MAX_RESOURCES_OTHER         = 2;
        //public const int MAX_RESOURCES_CAR_STEREO    = 1;
        //public const int MAX_ON_HOLD                 = 10;
        //public const int EXCESSIVE_WAIT_TIME         = 1;

        //// Delay Constants
        //public const double DELAY_ARRIVAL            = 0.333;
        //public const double DELAY_IVR                = 0.3;
        //public const int    DELAY_PROCESSING         = 2;

        // String outputs
        public const string ARRIVAL                  = "ARRIVAL";
        public const string SWITCH                   = "SWITCH";
        public const string OTHER_QUEUE              = "OTHER_QUEUE";
        public const string STEREO_QUEUE             = "CAR_STEREO_QUEUE";
        public const string OTHER_RESOURCE           = "OTHER_RESOURCE";
        public const string STEREO_RESOURCE          = "CAR_STEREO_RESOURCE";
        public const string END                      = "END";
    }
}
