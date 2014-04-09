using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireAlarm
{
    public class FireMonitorSubject
    {
        public delegate void FireEventHandler(object sender, FireEventArgs fe);

        public event FireEventHandler FireEvent;

        public void OnFireEvent(string fireCatagory)
        {
            FireEventArgs fe = new FireEventArgs(fireCatagory);

            if (FireEvent != null)
                FireEvent(this, fe);
        }
    }
}
