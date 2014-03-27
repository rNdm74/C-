using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPattern_Bicycle
{
    interface IObserver
    {
        void Update(int data, int data, int data);
        void Display();
        void Compute();
    }

    abstract class Observer : IObserver
    {
        protected const int METER = 100;
        protected const int KILOMETER = 1000;
        protected const int HOUR = 60;
        protected const int FACTOR = 5;
        protected const int CIRCUMFERENCE = 205;

        protected int currentRPM;
        protected double currentComputedValue;
        protected ListBox display;
        protected ISubject subject;

        public Observer(ListBox display, ISubject subject)
        {
            this.display = display;
            this.subject = subject;

            currentRPM = 0;
            currentComputedValue = 0;
            // IMPORTANT
            subject.AddObserver(this);
        }

        public abstract void Update(int data);
        public abstract void Display();
        public abstract void Compute();
    }

    class Rpm : Observer
    {
        public Rpm(ListBox display, ISubject subject)
            : base(display, subject) { }

        public override void Update(int data)
        {
            currentComputedValue = (double)data;
            Display();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Compute()
        {
            throw new NotImplementedException();
        }
    }

    class Cph : Observer
    {
        public Cph(ListBox display, ISubject subject)
            : base(display, subject) { }

        public override void Update(int data)
        {
            currentComputedValue = (double)data * FACTOR;
            Display();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Compute()
        {
            throw new NotImplementedException();
        }
    }

    class Kmh : Observer 
    {
        public Kmh(ListBox display, ISubject subject)
            : base(display, subject) { }

        public override void Update(int data)
        {
            // Version 2
            double rpm = data;
            double distance = (METER * KILOMETER) / CIRCUMFERENCE;
            currentComputedValue = (rpm * HOUR) / distance;
            
            // Version 1 - Not sure if correct
            //// per minute
            //currentComputedValue = (CIRCUMFERENCE * data);
            //// per hour
            //currentComputedValue = currentComputedValue * HOUR;
            //// to meters
            //currentComputedValue = currentComputedValue / METER;
            //// to kms
            //currentComputedValue = currentComputedValue / KILOMETER;

            Display();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Compute()
        {
            throw new NotImplementedException();
        }
    }
}
