using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Entity
    {
        private int Id;
        public int ID                   { get { return Id; } }

        public ECallType? CallType      { get; set; }
        public int StartTime            { get; set; }
        public int BeginWait            { get; set; }
        public int StartProcessingTime  { get; set; }
        public int EndTime              { get; set; }
        public Resource AssignResource  { get; set; }
        
        public Entity(int Id) 
        {
            this.Id = Id;
        }
    }
}
