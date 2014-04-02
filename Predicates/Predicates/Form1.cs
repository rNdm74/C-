using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Predicates
{
    public partial class Form1 : Form
    {
        private const int MAX = 100;

        private Random rGen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rGen = new Random();
        }

        private void bEvenNumbers_Click(object sender, EventArgs e)
        {
            Predicate<int> isEvenPredicate = new Predicate<int>(isEven);
            process(isEvenPredicate);
        }

        private void bLessThanTen_Click(object sender, EventArgs e)
        {
            Predicate<int> isLessThanTenPredicate = new Predicate<int>(isLessThanTen);
            process(isLessThanTenPredicate);
        }

        private void process(Predicate<int> predicate)
        {
            // Clear displays
            lbResult.Items.Clear();
            lbSource.Items.Clear();

            // Generate Numbers
            for (int i = 0; i < MAX; i++)
                lbSource.Items.Add(rGen.Next(MAX));

            // Make int list from lbSource
            List<int> sourceList = lbSource.Items.Cast<int>().ToList();

            // Display all numbers that match predicate
            foreach (int number in sourceList.FindAll(predicate))
                lbResult.Items.Add(number);
        }

        private bool isEven(int number) 
        {
            bool isEven = number % 2 == 0;
            return isEven;
        }

        private bool isLessThanTen(int number) 
        {
            bool isLessthanTen = number < 10;
            return isLessthanTen;
        }
    }
}
