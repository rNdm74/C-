using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern_Bicycle
{
    interface ISubject
    {
        void UpdateData(int temp, int humidity, int pressure);
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class Subject : ISubject
    {
        private List<IObserver> observerList;
        private int temp;
        private int humidity;
        private int pressure;
        
        public Subject() 
        {
            temp = humidity = pressure = 0;
            observerList = new List<IObserver>();
        }


        public void ChangeSpeed(int temp, int humidity, int pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
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
                currentObserver.Update(temp, humidity, pressure);
        }
    }
}
