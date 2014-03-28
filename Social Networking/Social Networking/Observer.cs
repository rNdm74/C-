using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Social_Networking
{
    interface IObserver
    {
        void Update(string update);
        void Display();
    }

    abstract class Observer : IObserver
    {
        protected string update;
        protected ListBox display;
        protected ISubject subject;

        public Observer(ListBox display, ISubject subject)
        {
            this.display = display;
            this.subject = subject;

            // IMPORTANT
            subject.AddObserver(this);
        }

        public abstract void Update(string update);
        public abstract void Display();       
    }

    class MainPage : Observer
    {
        public MainPage(ListBox display, ISubject subject)
            : base(display, subject) { }

        public override void Update(string update)
        {
            this.update = update;
            Display();
        }

        public override void Display()
        {
            display.Items.Clear();
            display.Items.Add(update);
        }
    }

    class Friend : Observer
    {
        private string timestamp;

        public Friend(ListBox display, ISubject subject)
            : base(display, subject) { }

        public override void Update(string update)
        {
            timestamp = DateTime.Now.ToString();
            this.update = update;

            Display();
        }

        public override void Display()
        {
            display.Items.Add(timestamp);
            display.Items.Add(update);
        }
    }
}
