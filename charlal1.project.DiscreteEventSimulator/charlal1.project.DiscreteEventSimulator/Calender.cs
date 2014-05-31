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
            // Set global clock to simulation start time
            
            events = new List<Event>();

            //Event endSimulation = eventFactory.Spawn(EEventType.END_SIMULATION);
            //endSimulation.CurrentEntity = entityFactory.CreateEntity();
            //endSimulation.EventTime = SimulationEndDateTime;

            

            //events.Add(eventFactory.Spawn(EEventType.END_SIMULATION));
            //events.Add(eventFactory.Spawn(EEventType.ARRIVAL));
            //events.Sort();
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

        //public void Worker(Event activeEvent) 
        //{
        //    // Remove first event in calender list
        //    events.RemoveAt(0);

        //    // Spawn new arrival

        //    // Update the global clock to events execution time
        //    Global.Clock = activeEvent.EventTime;

        //    // Process event
        //    //activeEvent.Process();

        //    // Update sytem stats if required
        //    //statistics.Update();
        //}
                
        //public void UpdateEntity(Entity activeEntity)
        //{
        //    // if event is arrival update entities state
        //    //activeEntity.StartTime = activeEntity.EventTime;

        //    // if event is switchcomplete entity is in queue
            
        //    // if event is processingcomplete entity
        //}

        //public void UpdateSytem() 
        //{
        //    // Move entity into queue
        //}

        //public void SpawnNewEvent(Entity activeEntity)
        //{
        //    // Get active entities next event
        //    EEventType nextEventType = activeEntity.NextEvent;
                      
        //    // Create next event for entity
        //    Event nextEvent = eventFactory.Spawn(nextEventType);
        //    nextEvent.EventTime = activeEntity.BeginWait;
        //    nextEvent.CurrentEntity = activeEntity;

        //    // Add event to calender
        //    events.Add(nextEvent);
        //}

        //public Entity SpawnNewEntity() 
        //{
        //    // on arrival event is put into calender   
        //    return entityFactory.CreateEntity();
        //}
    }
}
