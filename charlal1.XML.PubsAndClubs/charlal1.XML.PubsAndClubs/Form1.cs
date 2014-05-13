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

        /// <summary>
        /// Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load XML from folder
            pubsClubs = XDocument.Load("pubsClubs.xml");

            // Populate ComboBox
            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string genre = item.Element("Band").Element("Genre").Value.Trim();
                
                if (!cbGenres.Items.Contains(genre))
                    cbGenres.Items.Add(genre);                                                
            }

            // Set the First Item in the ComboBox
            cbGenres.Text = cbGenres.Items[0].ToString();

            // Update Display
            UpdateDisplay();            
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;

            // Error checking
            if (selectedCells.Count > 0 && dataGridView.CurrentCell.RowIndex < dataGridView.Rows.Count - 1)
            {
                // Only updates ID when Add Event is not checked
                if (!rbAddEvent.Checked)
                    lIDValue.Text = selectedCells[0].Value.ToString();

                tbEventName.Text = selectedCells[1].Value.ToString();

                string date = selectedCells[2].Value.ToString();
                DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                dtpDate.Text = dt.ToString();

                tbStartTime.Text = selectedCells[3].Value.ToString();
                tbEndTime.Text = selectedCells[4].Value.ToString();
                tbCoverPrice.Text = selectedCells[5].Value.ToString();
                nUpDownAgeLimit.Value = Convert.ToInt16(selectedCells[6].Value);
                tbClubName.Text = selectedCells[7].Value.ToString();
                tbClubAddress.Text = selectedCells[8].Value.ToString();
                tbBandName.Text = selectedCells[9].Value.ToString();
                tbBandGenre.Text = selectedCells[10].Value.ToString();
            }
        }

        private void cbGenres_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void rbAllMonths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void bAddEvent_Click(object sender, EventArgs e)
        {
            if (rbEditEvent.Checked)
                EditEvent();
            else if (rbAddEvent.Checked)
                AddEvent();
            else if (rbDeleteEvent.Checked)
                DeleteEvent();

            UpdateDisplay();
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Text == "Edit Event")
            {
                bAddEvent.Text = "Edit Event";
                lIDValue.Text = dgvDisplay.CurrentCell.RowIndex.ToString();
            }
            else if (rb.Text == "Add Event")
            {
                bAddEvent.Text = "Add Event";
                lIDValue.Text = (dgvDisplay.RowCount - 1).ToString();
            }
            else if (rb.Text == "Delete Event")
            {
                bAddEvent.Text = "Delete Event";
                lIDValue.Text = dgvDisplay.CurrentCell.RowIndex.ToString();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            pubsClubs.Save("pubsClubs.xml");
        }
        
        /// <summary>
        /// Methods
        /// </summary>
        /// <param name="selection"></param>
        private void UpdateDisplay()
        {
            string selection = cbGenres.SelectedItem.ToString();

            if (selection == "All Genres" && rbAllMonths.Checked)
                // Display All Genres
                DisplayAllGenres();
            else if (rbAllMonths.Checked)
                // Display Only Selected Genres
                DisplaySelectedGenres(selection);
            else if (selection == "All Genres" && rbThisMonth.Checked)
                // Display All Genres For Current Month 
                DisplayAllGenresCurrentMonth();
            else if (rbThisMonth.Checked)
                // Display Only Selected Genres For Current Month 
                DisplaySelectedGenresCurrentMonth(selection);
        }
        
        private void DisplayAllGenres()
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = GetItems(item);
                dgvDisplay.Rows.Add(items);
            }

            dgvDisplay.Refresh();
        }
        
        private void DisplaySelectedGenres(string selection)
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = GetItems(item);

                string genre = item.Element("Band").Element("Genre").Value.Trim();

                if (selection == genre)
                    dgvDisplay.Rows.Add(items);
            }

            dgvDisplay.Refresh();
        }

        private void DisplayAllGenresCurrentMonth()
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = GetItems(item);

                if (IsInMonth(item))
                    dgvDisplay.Rows.Add(items);
            }

            dgvDisplay.Refresh();
        }

        private void DisplaySelectedGenresCurrentMonth(string selection)
        {
            // Clear Gridview
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                // Items From Element
                string[] items = GetItems(item);

                // Genre From Tree
                string genre = item.Element("Band").Element("Genre").Value.Trim();

                // Display Row when Item is in current month AND comboBox selection equals the Items Genre
                if (IsInMonth(item))
                    if (selection == genre)
                        dgvDisplay.Rows.Add(items);
            }

            // Refresh the DataGridView
            dgvDisplay.Refresh();
        }
        
        private bool IsInMonth(XElement item)
        {
            // Get Date
            string date = item.Element("Date").Value;

            // Convert To DateTime For Calculation
            DateTime convertedDate = DateTime.ParseExact(date, "dd/MM/yyyy", null);

            // Todays Date
            DateTime today = DateTime.Today;

            // First Day of Next Month
            DateTime firstDayOfNextMonth = new DateTime(today.Year, today.Month, 1).AddMonths(1);

            // Return If Date in Current Month
            return (convertedDate < firstDayOfNextMonth);
        }
        
        private string[] GetItems(XElement item)
        {
            return new string[]
            {
                item.Attribute("ID").Value,
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
        }
                
        private void DeleteEvent()
        {
            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                if (item.Attribute("ID").Value == lIDValue.Text)
                    item.Remove();
            }
        }

        private void EditEvent()
        {
            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                if (item.Attribute("ID").Value == lIDValue.Text)
                {
                    item.Attribute("TITLE").Value = tbEventName.Text;
                    item.Element("Date").Value = dtpDate.Text;
                    item.Element("StartTime").Value = tbStartTime.Text;
                    item.Element("EndTime").Value = tbEndTime.Text;
                    item.Element("CoverPrice").Value = tbCoverPrice.Text;
                    item.Element("AgeLimit").Value = nUpDownAgeLimit.Value.ToString();
                    item.Element("Club").Element("Name").Value = tbClubName.Text;
                    item.Element("Club").Element("Address").Value = tbClubAddress.Text;
                    item.Element("Band").Element("Name").Value = tbBandName.Text;
                    item.Element("Band").Element("Genre").Value = tbBandGenre.Text; 
                }                
            }
        }
        
        private void AddEvent()
        {
            // Build event
            XElement newEvent = new XElement("Event",
                new XAttribute("TITLE", tbEventName.Text),
                new XAttribute("ID", lIDValue.Text),
                new XElement("Date", dtpDate.Text),
                new XElement("StartTime", tbStartTime.Text),
                new XElement("EndTime", tbEndTime.Text),
                new XElement("CoverPrice", tbCoverPrice.Text),
                new XElement("AgeLimit", nUpDownAgeLimit.Value),
                new XElement("Club",
                    new XElement("Name", tbClubName.Text),
                    new XElement("Address", tbClubAddress.Text)
                ),
                new XElement("Band",
                    new XElement("Name", tbBandName.Text),
                    new XElement("Genre", tbBandGenre.Text)
                )
            );

            // Add to tree
            pubsClubs.Element("Gig").Add(newEvent);

            // Goto edit view
            rbEditEvent.Checked = true;
        }        
    }
}
