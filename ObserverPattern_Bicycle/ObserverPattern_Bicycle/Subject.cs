using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern_Bicycle
{
    interface ISubject
    {
        void ChangeSpeed(int rpm);
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class Subject : ISubject
    {
        private List<IObserver> observerList;
        private int currentRpm;
        
        public Subject() 
        {
            currentRpm = 0;
            observerList = new List<IObserver>();
        }


        public void ChangeSpeed(int rpm)
        {
            currentRpm = rpm;
        }
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            // Add error checking
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver currentObserver in observerList)
                currentObserver.Update(currentRpm);
        }
    }
}
