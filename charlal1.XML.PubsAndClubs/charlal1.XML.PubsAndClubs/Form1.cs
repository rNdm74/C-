using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace charlal1.XML.PubsAndClubs
{
    public partial class Form1 : Form
    {
        private XDocument pubsClubs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pubsClubs = XDocument.Load("pubsClubs.xml");

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                //lbDebug.Items.Add(item.Attribute("TITLE").Value);

                string genre = item.Element("Band").Element("Genre").Value;

                if (!cbGenres.Items.Contains(genre))
                    cbGenres.Items.Add(genre);


                string[] items = new string[]
                {
                    item.Attribute("TITLE").Value,
                    item.Element("Date").Value,
                    item.Element("StartTime").Value,
                    item.Element("EndTime").Value,
                    item.Element("CoverPrice").Value,
                    item.Element("AgeLimit").Value,
                    item.Element("Club").Element("Name").Value,
                    item.Element("Club").Element("Address").Value,
                    item.Element("Band").Element("Name").Value,
                    item.Element("Band").Element("Genre").Value                                    
                };

                //DataGridViewRow dataGridViewRow = new DataGridViewRow();
                //dataGridViewRow.CreateCells(dgvDisplay, items);

                dgvDisplay.Rows.Add(items);
                                                
            }

            cbGenres.Text = cbGenres.Items[0].ToString();

             
            //dgvDisplay.Rows.Add(
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView dataGridView = (DataGridView)sender;

                DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;
                                
                string date = selectedCells[1].Value.ToString();
                DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", null);

                tbEventName.Text = selectedCells[0].Value.ToString();
                dtpDate.Text = dt.ToString();
                tbStartTime.Text = selectedCells[2].Value.ToString();
                tbEndTime.Text = selectedCells[3].Value.ToString();
                tbCoverPrice.Text = selectedCells[4].Value.ToString();
                nUpDownAgeLimit.Value = Convert.ToInt16(selectedCells[5].Value);
                tbClubName.Text = selectedCells[6].Value.ToString();
                tbClubAddress.Text = selectedCells[7].Value.ToString();
                tbBandName.Text = selectedCells[8].Value.ToString();
                tbBandGenre.Text = selectedCells[9].Value.ToString();
            }
            catch (Exception)
            {
            }
            
        }

        private void cbGenres_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = new string[]
                {
                    item.Attribute("TITLE").Value,
                    item.Element("Date").Value,
                    item.Element("StartTime").Value,
                    item.Element("EndTime").Value,
                    item.Element("CoverPrice").Value,
                    item.Element("AgeLimit").Value,
                    item.Element("Club").Element("Name").Value,
                    item.Element("Club").Element("Address").Value,
                    item.Element("Band").Element("Name").Value,
                    item.Element("Band").Element("Genre").Value                                    
                };
                
                string genre = item.Element("Band").Element("Genre").Value.Trim();
                string selection = cbGenres.SelectedItem.ToString();

                if(selection == genre)
                    dgvDisplay.Rows.Add(items);
                else if(selection == "All Genres")
                    dgvDisplay.Rows.Add(items);
            }

            dgvDisplay.Refresh();
        }

        private void rbAllMonths_CheckedChanged(object sender, EventArgs e)
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = new string[]
                {
                    item.Attribute("TITLE").Value,
                    item.Element("Date").Value,
                    item.Element("StartTime").Value,
                    item.Element("EndTime").Value,
                    item.Element("CoverPrice").Value,
                    item.Element("AgeLimit").Value,
                    item.Element("Club").Element("Name").Value,
                    item.Element("Club").Element("Address").Value,
                    item.Element("Band").Element("Name").Value,
                    item.Element("Band").Element("Genre").Value                                    
                };

                string genre = item.Element("Band").Element("Genre").Value.Trim();
                string selection = cbGenres.SelectedItem.ToString();

                RadioButton rb = (RadioButton) sender;

                if (rb.Text == "All Months")
                {
                    if (selection == genre)
                        dgvDisplay.Rows.Add(items);
                    else if (selection == "All Genres")
                        dgvDisplay.Rows.Add(items);
                }
                else if (rb.Text == "This Month") 
                {
                    string date = item.Element("Date").Value;
                    DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", null);

                    DateTime today = DateTime.Today;
                    DateTime endOfMonth = new DateTime(today.Year, today.Month, 1).AddMonths(1);

                    if (dt < endOfMonth)
                    {
                        if (selection == genre)
                            dgvDisplay.Rows.Add(items);
                        else if (selection == "All Genres")
                            dgvDisplay.Rows.Add(items);
                             
                    }
                }
                                  
            }

            dgvDisplay.Refresh();

            
        }        
    }
}
