using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weather_Station
{
    public partial class Form1 : Form
    {
        private ISubject subject;
        private IObserver[] observers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new Subject();
            observers = new IObserver[]
            {
                new CurrentReadings(lbCurrentReadings, subject),
                new AverageReadings(lbAverageReadings, subject),
                new Forecast(lbForecast, subject),
            };
        }

        private void bUpdateMeasurements_Click(object sender, EventArgs e)
        {
            int temp = (int)nTemperature.Value;
            int humidity = (int)nHumidity.Value;
            int bPressure = (int)nBPressure.Value;

            subject.UpdateData(temp, humidity, bPressure);
            subject.NotifyObservers();
        }
    }
}
