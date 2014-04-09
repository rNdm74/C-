using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void bTestHandlers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Form's Handler");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CustomHandlers ch = new CustomHandlers(bTestHandlers);
        }
    }
}
