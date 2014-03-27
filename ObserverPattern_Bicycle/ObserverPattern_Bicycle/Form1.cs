using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPattern_Bicycle
{
    public partial class Form1 : Form
    {
        private ISubject bicycleSubject;
        private IObserver[] bicycleObservers;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bicycleSubject = new Subject();
            bicycleObservers = new IObserver[]
            {
                new Rpm(lRpm, bicycleSubject),
                new Cph(lCph, bicycleSubject),
                new Kmh(lKmh, bicycleSubject),
            };
        }

        private void bChangeSpeed_Click(object sender, EventArgs e)
        {
            bicycleSubject.ChangeSpeed((int)nChangeSpeed.Value);
            bicycleSubject.NotifyObservers();
        }
    }
}
