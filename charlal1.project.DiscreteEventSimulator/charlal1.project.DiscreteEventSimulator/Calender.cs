using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1.project.DiscreteEventSimulator
{
    class Calender
    {
        private Statistics statistics;
        private EventFactory eventFactory;
        private EntityFactory entityFactory;
        private List<Event> events;

        private RandomNumberGenerator randomNumberGenerator;
        
        public Calender(DateTime SimulationStartDateTime, DateTime SimulationEndDateTime) 
        {
            // Set global clock to simulation start time
            Global.Clock = SimulationStartDateTime;

            randomNumberGenerator = new RandomNumberGenerator();

            statistics = new Statistics();
            eventFactory = new EventFactory();
            entityFactory = new EntityFactory();

            Event endSimulation = eventFactory.Spawn(EEventType.END_SIMULATION);
            endSimulation.CurrentEntity = entityFactory.CreateEntity();
            endSimulation.EventTime = SimulationEndDateTime;

            events = new List<Event>();

            events.Add(eventFactory.Spawn(EEventType.END_SIMULATION));
            events.Add(eventFactory.Spawn(EEventType.ARRIVAL));
            events.Sort();
        }

        public void Worker(Event activeEvent) 
        {
            // Remove first event in calender list
            events.RemoveAt(0);

            // Spawn new arrival

            // Update the global clock to events execution time
            Global.Clock = activeEvent.EventTime;

            // Process event
            //activeEvent.Process();

            // Update sytem stats if required
            //statistics.Update();
        }

        // Processing of an event
        public Event GetNextEvent() 
        {
            return events[0];
        }

        public void UpdateEntity(Entity activeEntity)
        {
            // if event is arrival update entities state
            //activeEntity.StartTime = activeEntity.EventTime;

            // if event is switchcomplete entity is in queue
            
            // if event is processingcomplete entity
        }

        public void UpdateSytem() 
        {
            // Move entity into queue
        }

        public void SpawnNewEvent(Entity activeEntity)
        {
            // Get active entities next event
            EEventType nextEventType = activeEntity.NextEvent;
                      
            // Create next event for entity
            Event nextEvent = eventFactory.Spawn(nextEventType);
            nextEvent.EventTime = activeEntity.BeginWait;
            nextEvent.CurrentEntity = activeEntity;

            // Add event to calender
            events.Add(nextEvent);
        }

        public Entity SpawnNewEntity() 
        {
            // on arrival event is put into calender   
            return entityFactory.CreateEntity();
        }
    }
}
