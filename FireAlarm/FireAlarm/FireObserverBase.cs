using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FireAlarm
{
    public abstract class FireObserverBase
    {
        public FireObserverBase(FireMonitorSubject fireMonitorSubject)
        {
            fireMonitorSubject.FireEvent += new FireMonitorSubject.FireEventHandler(fireHandler);
        }

        protected abstract void fireHandler(object sender, FireEventArgs fe);
    }

    public class InstructionsFireObserver : FireObserverBase
    {
        public InstructionsFireObserver(FireMonitorSubject fireMonitorSubject)
            : base(fireMonitorSubject)
        { 
        }

        protected override void fireHandler(object sender, FireEventArgs fe)
        {
            string message = "Fire is " + fe.FireCatagory + ". ";

            switch (fe.FireCatagory)
            {
                case "Minor":
                    message += "Use an extinguisher";
                    break;
                case "Serious":
                    message += "Call the Fire Department";
                    break;
                case "Inferno":
                    message += "Evacuate Immediatly!!";
                    break;
            }

            MessageBox.Show(message);
        }
    }

    public class AlarmBellFireObserver : FireObserverBase
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        public AlarmBellFireObserver(FireMonitorSubject fireMonitorSubject)
            : base(fireMonitorSubject)
        {
        }

        protected override void fireHandler(object sender, FireEventArgs fe)
        {
            int freq = 0;
            int duration = 1000;
            
            switch (fe.FireCatagory)
            {
                case "Minor":
                    freq = 800;
                    break;
                case "Serious":
                    freq = 1600;
                    break;
                case "Inferno":
                    freq = 3200;
                    break;
            }

            Beep(freq, duration);
        }
    }
}
