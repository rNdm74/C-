using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace charlal1_Alphabetic_Distribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            StreamReader sr = new StreamReader(myStream);
                            String unicodeString = sr.ReadToEnd();
                            //Make all lowercase
                            unicodeString = unicodeString.ToLower();
                            // Trim whitespace
                            unicodeString = unicodeString.Trim();
                            // Remove all white space, tabs, line feeds and carriage returns 
                            unicodeString = unicodeString.Replace(" ", "");
                            unicodeString = unicodeString.Replace("\t", "");
                            unicodeString = unicodeString.Replace("\n", "");
                            unicodeString = unicodeString.Replace("\r", "");

                            // Running char total
                            int runningTotal = 0;
                            char maxChar = '\0';

                            // Loops through the char set and adds the count of chars for each char
                            for (char letter = 'a'; letter <= 'z'; letter++)
			                {
                                // Gets the char count of each letter
                                int charCount = Regex.Matches(unicodeString, letter.ToString()).Count;

                                // Running total
                                if (charCount > runningTotal) 
                                {
                                    runningTotal = charCount;
                                    maxChar = letter;
                                }
                                    
                                // Adds to the list
                                lbResult.Items.Add(letter + ": " + charCount);
			                }

                            // Filename
                            lFilename.Text = openFileDialog1.FileName;
                            // Max char in distribution
                            lMaxChar.Text = maxChar.ToString();
                            // Displays total char count
                            lTotalChars.Text = unicodeString.Length.ToString();                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
