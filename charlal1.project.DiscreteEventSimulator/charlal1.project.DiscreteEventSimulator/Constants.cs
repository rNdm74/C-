using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    public static class Constants
    {
        // Constants for settings
        public const int OTHER_MAX_RESOURCES         = 2;
        public const int CAR_STEREO_MAX_RESOURCES    = 1;
        public const int MAX_ON_HOLD                 = 10;
        public const double EXCESSIVE_WAIT_TIME      = 1.000;
        public const double ARRIVAL_DELAY            = 0.333;
        public const double SWITCH_DELAY             = 0.300;
        public const double PROCESSING_DELAY         = 2.000;
        public const int CALL_TYPE_PROBABILITY       = 4;

        // Simulation Constants
        public const int FIRST_IN_QUEUE              = 0;
        public const int EVENT_ENTITY_POS            = 0;
        public const int EVENT_TYPE_POS              = 1;
        public const int EVENT_CALL_TYPE_POS         = 3;
        public const int CONVERT_TO_SECONDS          = 60;
        public const int DATE_TIME_FACTOR            = 100;
        public const int LABEL_SIZE                  = 64;
        public const int LABEL_START_X               = 32;
        public const int LABEL_START_Y               = 32;
        public const string TYPE_1                   = "Other";
        public const string TYPE_2                   = "Car Stereo";

        // Export CSV Data header information
        public const string EXPORT_DATA_HEADER       =  
            "Iterations," +
            "Busy Signal," +
            "Call Completion," +
            "Call Completion " + TYPE_1 + "," +
            "Call Completion " + TYPE_2 + "," +
            "Excessive Wait Count," +
            "Excessive Wait Count " + TYPE_1 + "," +
            "Excessive Wait Count " + TYPE_2 + "," +
            "Resource Utilization," +
            "Resource " + TYPE_1 + " Utilization," +
            "Resource " + TYPE_2 + " Utilization," +
            "Resourse " + TYPE_1 + " Work Time," +
            "Resourse " + TYPE_2 + " Work Time," +
            "Resourse Work Time," +
            "System Time," +
            "Average Number Waiting," +
            "Average Waiting Time," +
            "Average Number Waiting " + TYPE_1 + "," +
            "Average Number Waiting " + TYPE_2 + "," +
            "Average System Time";
    }
}
