﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    enum ECallType { CAR_STEREO, OTHER }
    enum EEventType { ARRIVAL, SWITCH_COMPLETE, PROCESSING_COMPLETE, END_SIMULATION }
    enum ELabelType { L_ARRIVAL, L_SWITCH, L_QUEUE_TYPE_1, L_QUEUE_TYPE_2, L_RESOURCE_TYPE_1, L_RESOURCE_TYPE_2 }

    public sealed class Global
    {
        public static void Init()
        {
            // Set integers to 0
            BusySignalCount =
            CallCompletion =
            CallCompletionType1 =
            CallCompletionType2 =
            ExcessiveWaitCount =
            ExcessiveWaitCountType1 =
            ExcessiveWaitCountType2 =
            Iterations =
            ResourcesUsed =
            WaitCount =
            WaitCountType1 =
            WaitCountType2 = 0;

            // Set doubles to 0
            AverageWaitingTime =
            AverageSystemTime =
            AverageNumberWaiting =
            AverageNumberWaitingType1 =
            AverageNumberWaitingType2 =
            ResourceUtilization =
            ResourseType1TotalWorkTime =
            ResourseType2TotalWorkTime =
            ResourseTotalWorkTime =
            SystemTime = 0;
        }

        ///<summary>
        /// All global variables for the simulator
        ///</summary>
        ///
        // Simulation
        public static int Clock { get; set; }
        public static int SimulationSpeed { get; set; }
        public static bool ExportCSV { get; set; }
        public static int StartSimulationTime { get; set; }
        public static int EndSimulationTime { get; set; }
        public static int MaxResourcesType1 { get; set; }
        public static int MaxResourcesType2 { get; set; }
        public static int MaxOnHold { get; set; }
        public static int ExcessiveWaitTime { get; set; }
        public static int CallTypeProbability { get; set; }

        // Delay
        public static double DelayArrival { get; set; }
        public static double DelaySwitch { get; set; }
        public static double DelayProcessing { get; set; }

        // Statistics
        public static int Iterations { get; set; }
        public static int ResourcesUsed { get; set; }

        public static int BusySignalCount { get; set; }
        public static int CallCompletion { get; set; }
        public static int CallCompletionType1 { get; set; }
        public static int CallCompletionType2 { get; set; }
        public static int ExcessiveWaitCount { get; set; }
        public static int ExcessiveWaitCountType1 { get; set; }
        public static int ExcessiveWaitCountType2 { get; set; }
        public static int WaitCount { get; set; }
        public static int WaitCountType1 { get; set; }
        public static int WaitCountType2 { get; set; }

        public static double ResourceUtilization { get; set; }
        public static double ResourceType1Utilization { get; set; }
        public static double ResourceType2Utilization { get; set; }
        public static double ResourseType1TotalWorkTime { get; set; }
        public static double ResourseType2TotalWorkTime { get; set; }
        public static double ResourseTotalWorkTime { get; set; }
        public static double SystemTime { get; set; }

        public static double AverageNumberWaiting { get; set; }
        public static double AverageWaitingTime { get; set; }
        public static double AverageNumberWaitingType1 { get; set; }
        public static double AverageNumberWaitingType2 { get; set; }
        public static double AverageSystemTime { get; set; }
    }
}
