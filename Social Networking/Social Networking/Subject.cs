using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Social_Networking
{
    interface ISubject
    {
        void UpdateData(string update);
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class Subject : ISubject
    {
        private List<IObserver> observerList;
        private string update;
        
        public Subject() 
        {
            update = "";
            observerList = new List<IObserver>();
        }
        
        public void UpdateData(string update)
        {
            this.update = update;
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
                currentObserver.Update(update);
        }
    }
}
