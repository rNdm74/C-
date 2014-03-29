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
        double Compute(int newValue, double avgValue, int count);
    }

    /// <summary>
    /// Abstract Observer Interface
    /// </summary>
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
        public virtual double Compute(int newValue, double avgValue, int count)
        {
            // Does nothing
            return 0;
        }
    }

    /// <summary>
    /// Current Readings
    /// </summary>
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

    /// <summary>
    /// Calculates the average readings
    /// </summary>
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
            SetAverages(temp, humidity, bPressure);
            Display();
        }

        public override void Display()
        {
            display.Items.Clear();
            display.Items.Add("Average Temperature: " + avgTemp.ToString("F2"));
            display.Items.Add("Average Humidity: " + avgHumidity.ToString("F2"));
            display.Items.Add("Average Pressure: " + avgBPressure.ToString("F2"));
        }

        private void SetAverages(int temp, int humidity, int bPressure)
        {
            count++;
            avgTemp += Compute(temp, avgTemp, count);
            avgHumidity += Compute(humidity, avgHumidity, count);
            avgBPressure += Compute(bPressure, avgBPressure, count);
        }

        public override double Compute(int newValue, double avgValue, int count) 
        {
            return (newValue - avgValue) / count;
        }
    }

    /// <summary>
    /// Displays the weather forecast
    /// </summary>
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
