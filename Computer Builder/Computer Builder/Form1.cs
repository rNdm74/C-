using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Builder
{
    public enum COMPUTER 
    {
        BUSINESS,
        GAMING,        
        MEDIA
    }

    public partial class Form1 : Form
    {
        private IFormControlManager fcManager;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void bQuery_Click(object sender, EventArgs e)
        {
            fcManager = new FormControlManager(lbDisplay);
            fcManager.update(ComputerType());
            fcManager.display();
        }

        private COMPUTER ComputerType()
        {
            RadioButton[] rButtons = new RadioButton[] { rbBusiness, rbGaming, rbMedia };

            int count = 0;

            while (rButtons[count].Checked == false)
                count++;

            return (COMPUTER)count;
        } 
    }
}
