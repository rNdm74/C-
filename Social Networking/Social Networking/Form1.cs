using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Social_Networking
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
                new MainPage(lbMainPage, subject),
                new Friend(lbFriend1, subject),
                new Friend(lbFriend2, subject),
                new Friend(lbFriend3, subject),
                new Friend(lbFriend4, subject)
            };
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            subject.UpdateData(tbUpdateString.Text);
            subject.NotifyObservers();
        }
    }
}
