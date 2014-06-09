using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Calender
    {
        public List<Event> events;
                
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

        public List<string[]> GetEventData() 
        {
            List<string[]> eventData = new List<string[]>();

            foreach (Event e in events)
            {                
                Entity eventEntity = e.CurrentEntity;

                eventData.Add(rowData(e, eventEntity));
            }

            return eventData;
        }

        private string[] rowData(Event currentEvent, Entity currentEntity)
        {
            TimeSpan et = TimeSpan.FromSeconds(currentEvent.EventTime);
            TimeSpan st = TimeSpan.FromSeconds(currentEntity.StartTime);
            TimeSpan wt = TimeSpan.FromSeconds(currentEntity.BeginWait);

            // Get statistics
            string entityID = currentEntity.ID.ToString();
            string eventType = (currentEvent == null) ? "---" : currentEvent.EventType.ToString();
            string eventTime = (currentEvent == null) ? "---" : string.Format("{0:D1}:{1:D2}:{2:D2}", (et.Hours + (Global.START_SIMULATION_TIME  / 1000)) - 1, et.Minutes, et.Seconds);
            string entityCallType = (currentEntity.CallType == null) ? "---" : currentEntity.CallType.ToString();
            string entityStartTime = string.Format("{0:D1}:{1:D2}:{2:D2}", st.Hours, st.Minutes, st.Seconds);//(currentEntity.StartTime.ToString("yyyy").Equals("0001")) ? "---" : currentEntity.StartTime.ToShortTimeString();
            string entityBeginWait = string.Format("{0:D1}:{1:D2}:{2:D2}", wt.Hours, wt.Minutes, wt.Seconds);//(currentEntity.BeginWait.ToString("yyyy").Equals("0001")) ? "---" : currentEntity.BeginWait.ToShortTimeString();

            // return data string array
            return new string[] { entityID, eventType, eventTime, entityCallType, entityStartTime, entityBeginWait };
        }
    }
}
