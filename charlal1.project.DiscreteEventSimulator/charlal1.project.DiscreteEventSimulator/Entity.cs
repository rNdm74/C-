using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Entity
    {
        private int Id;
        public int ID               { get { return Id; } }

        public EEventType NextEvent { get; set; }
        public ECallType CallType   { get; set; }
        public DateTime StartTime   { get; set; }
        public DateTime BeginWait   { get; set; }
        
        public Entity(int Id) 
        {
            this.Id = Id;
        }
    }
}
