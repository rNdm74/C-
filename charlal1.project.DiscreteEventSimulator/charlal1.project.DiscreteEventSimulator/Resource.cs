﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Resource
    {        
        public bool IsFree          { get; set; }
        public ECallType CallType   { get; set; }

        public Resource(ECallType callType) 
        {
            this.CallType = callType;
            this.IsFree = true;
        }
    }
}
