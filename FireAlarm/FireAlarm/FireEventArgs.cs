using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireAlarm
{
    public class FireEventArgs
    {
        private string fireCatagory;
        public string FireCatagory
        {
            get { return fireCatagory; }
        }

        public FireEventArgs(string fireCatagory)
        {
            this.fireCatagory = fireCatagory;
        }
    }
}
