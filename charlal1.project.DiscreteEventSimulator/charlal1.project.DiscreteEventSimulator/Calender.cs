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

        /// <summary>
        /// Return the next event from the list of events 
        /// </summary>
        public Event GetNextEvent()
        {
            // Get first event
            Event nextEvent = events.First();

            // Remove from list
            events.RemoveAt(0);

            // Return event
            return nextEvent;
        }

        /// <summary>
        /// Add an event to the list
        /// </summary>
        public void Add(Event e) 
        {
            // Add event to list
            events.Add(e);

            // Sort list on EventTime
            events.Sort((x, y) => x.EventTime.CompareTo(y.EventTime));
        }

        /// <summary>
        /// Remove event from the list
        /// </summary>
        public void Remove(Event e) 
        {
            // Check if event is in queue
            if (events.Contains(e))
            {
                // Get events index
                int index = events.IndexOf(e);

                // Remove event at found index
                events.RemoveAt(index);
            }
        }

        /// <summary>
        /// Return formatted list of data from the calender list
        /// To be displayed in a datagridview
        /// </summary>
        public List<string[]> GetEventData() 
        {
            // Make a new list for the formated event data
            List<string[]> eventData = new List<string[]>();

            // Add the event ToString, to the eventData list
            foreach (Event e in events)
                eventData.Add(e.ToString());

            return eventData;
        }
    }
}
