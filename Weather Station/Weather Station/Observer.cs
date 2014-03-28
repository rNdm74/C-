using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weather_Station
{
    interface IObserver
    {
        void Update(int temp, int humidity, int bPressure);
        void Display();
        void Compute(int temp, int humidity, int bPressure);
    }

    abstract class Observer : IObserver
    {
        protected int temp, humidity, bPressure;

        protected ListBox display;
        protected ISubject subject;

        public Observer(ListBox display, ISubject subject)
        {
            this.display = display;
            this.subject = subject;

            temp = humidity = bPressure = 0;

            // IMPORTANT
            subject.AddObserver(this);
        }

        public abstract void Update(int temp, int humidity, int bPressure);
        public abstract void Display();
        public virtual void Compute(int temp, int humidity, int bPressure)
        {
            // Does nothing
        }
    }

    class CurrentReadings : Observer
    {
        public CurrentReadings(ListBox display, ISubject subject)
            : base(display, subject) { }

        public override void Update(int temp, int humidity, int bPressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.bPressure = bPressure;

            Display();
        }

        public override void Display()
        {
            display.Items.Clear();
            display.Items.Add("Current Temperature: " + temp);
            display.Items.Add("Current Humidity: " + humidity);
            display.Items.Add("Current Pressure: " + bPressure);
        }
    }

    class AverageReadings : Observer
    {
        private int count;
        private double avgTemp, avgHumidity, avgBPressure;
               
        public AverageReadings(ListBox display, ISubject subject)
            : base(display, subject) 
        {
            count = 0;
            avgTemp = avgHumidity = avgBPressure = 0;
        }

        public override void Update(int temp, int humidity, int bPressure)
        {
            Compute(temp, humidity, bPressure);
            Display();
        }

        public override void Display()
        {
            display.Items.Clear();
            display.Items.Add("Average Temperature: " + avgTemp.ToString("F2"));
            display.Items.Add("Average Humidity: " + avgHumidity.ToString("F2"));
            display.Items.Add("Average Pressure: " + avgBPressure.ToString("F2"));
        }

        public override void Compute(int temp, int humidity, int bPressure)
        {
            count++;
            avgTemp += (temp - avgTemp) / count;
            avgHumidity += (humidity - avgHumidity) / count;
            avgBPressure += (bPressure - avgBPressure) / count;
        }
    }

    class Forecast : Observer 
    {
        private Random rGen;

        public Forecast(ListBox display, ISubject subject)
            : base(display, subject) 
        {
            rGen = new Random();
        }

        public override void Update(int temp, int humidity, int bPressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.bPressure = bPressure;
            
            Display();
        }

        public override void Display()
        {
            display.Items.Clear();
            display.Items.Add(getForecast(rGen.Next(5)));
        }

        private string getForecast(int rGen) 
        {
            switch (rGen)
            {
                case 0: return "Mainly cloudy with a little drizzle.";
                case 1: return "Slight chance of a rain shower.";
                case 2: return "Cold and dry in the morning.";
                case 3: return "Windy and increasingly cloudy with sunny periods.";
                case 4: return "Rain expected at night, with 40 percent chance of showers.";
                default: return "Sunny in the morning with cloudy intervals later in the day.";
            }
        }
    }
}
