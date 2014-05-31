using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Calender
    {
        private List<Event> events;
                
        public Calender() 
        {            
            events = new List<Event>();
        }

        // Processing of an event
        public Event GetNextEvent()
        {
            // Get first event
            Event nextEvent = events.First();

            // Remove from list
            events.RemoveAt(0);

            // Return event
            return nextEvent;
        }

        public void Add(Event e) 
        {
            // Add event to list
            events.Add(e);

            // Sort list on EventTime
            events.Sort((x, y) => x.EventTime.CompareTo(y.EventTime));
        }

        public void Remove(Event e) 
        {
            // Check if event is in queue

            // Get events index
            int index = events.IndexOf(e);

            // Remove event at found index
            events.RemoveAt(index);
        }
    }
}
