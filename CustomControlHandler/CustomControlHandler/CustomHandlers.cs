using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public class CustomHandlers
    {
        private int code1, code2;

        public CustomHandlers(Button bTestHandlers) 
        {
            bTestHandlers.Click += new EventHandler(CustomHandler1);
            bTestHandlers.Click += new EventHandler(CustomHandler2);

            Random rGen = new Random();

            code1 = rGen.Next(100);
            code2 = rGen.Next(100);
        }

        void CustomHandler1(object sender, EventArgs e)
        {
            string message = "";

            message += "This is a custom handler.\n\n";
            message += "My code is " + code1 + "\n\n";
            message += "My type is " + this.GetType().ToString() + "\n\n";
            message += "I am responding to button: " + ((Button)sender).Name;

            MessageBox.Show(message);
        }

        void CustomHandler2(object sender, EventArgs e)
        {
            string message = "";

            message += "This is a custom handler.\n\n";
            message += "My code is " + code2 + "\n\n";
            message += "My type is " + this.GetType().ToString() + "\n\n";
            message += "I am responding to button: " + ((Button)sender).Name;

            MessageBox.Show(message);
        }  
    }
}
