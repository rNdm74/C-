using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metronome
{
    class Metronome
    {
        public delegate void MetronomeHandler(object sender, MetronomeEventArgs me);
        public event MetronomeHandler MetronomeEvent;

        private Form form;
        private int runningCount;
        private int interval;
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        public Metronome(int interval, Form form) 
        {
            this.interval = interval;
            this.form = form;
            this.runningCount = 0;
        }

        public void OnMetronomeEvent()
        {
            MetronomeEventArgs me = new MetronomeEventArgs(++runningCount);

            if (MetronomeEvent != null)
                MetronomeEvent(this, me);
        }

        public void Start()
        {            
            for (int i = 1; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(Interval);
                OnMetronomeEvent();
            }
        }
    }

    class MetronomeEventArgs 
    {
        private string time;
        private int count;

        public string Time
        {
            get { return time; }
        }

        public int Count
        {
            get { return count; }
        }

        public MetronomeEventArgs(int count) 
        {
            time = DateTime.Now.ToString("hh:mm:ss tt");
            this.count = count;
        }
    }
}
