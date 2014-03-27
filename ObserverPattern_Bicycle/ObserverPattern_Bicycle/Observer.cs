using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPattern_Bicycle
{
    interface IObserver
    {
        void Update(int data);
        void Display();
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
        protected Label displayLabel;
        protected ISubject bikeSubject;

        public Observer(Label displayLabel, ISubject bikeSubject)
        {
            this.displayLabel = displayLabel;
            this.bikeSubject = bikeSubject;

            currentRPM = 0;
            currentComputedValue = 0;
            // IMPORTANT
            bikeSubject.AddObserver(this);
        }

        public abstract void Update(int data);

        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }

    class Rpm : Observer
    {
        public Rpm(Label displayLabel, ISubject bikeSubject)
            : base(displayLabel, bikeSubject) {}

        public override void Update(int data)
        {
            currentComputedValue = (double)data;
            Display();
        }
    }

    class Cph : Observer
    {
        public Cph(Label displayLabel, ISubject bikeSubject)
            : base(displayLabel, bikeSubject) {}

        public override void Update(int data)
        {
            currentComputedValue = (double)data * FACTOR;
            Display();
        }
    }

    class Kmh : Observer 
    {
        public Kmh(Label displayLabel, ISubject bikeSubject)
            : base(displayLabel, bikeSubject){}

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
    }
}
