using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Calender
    {
        private List<Event> EventList;

        public Calender(DateTime SimulationStartDateTime, DateTime SimulationEndDateTime) 
        {
            EventList = new List<Event>();

            EventList.Add(new EndSimulationEvent(SimulationEndDateTime));
            EventList.Add(new ArrivalEvent(SimulationStartDateTime));

            EventList.Sort();
        }

        public void Worker() 
        {
            // Remove first event in calender list
            // Update the global clock to events execution time
            // Process event
            // Update sytem stats is required
        }

        // Processing of an event
        public Event GetNextEvent() 
        {
            return EventList[0];
        }

        public void UpdateEntity()
        {
        }

        public void UpdateSytem() 
        {
        }

        public void SpawnNewEvent()
        {
        }

        public void SpawnNewEntity() 
        {
        }
    }
}
