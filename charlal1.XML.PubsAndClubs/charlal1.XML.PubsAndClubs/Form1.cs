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

        private void DisplaySelectedGenres(string selection)
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = GetItems(item);

                string genre = item.Element("Band").Element("Genre").Value.Trim();
                
                if(selection == genre)
                    dgvDisplay.Rows.Add(items);
            }

            dgvDisplay.Refresh();
        }

        private void DisplayAllGenres()
        {
            dgvDisplay.Rows.Clear();

            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                string[] items = GetItems(item);
                if(items != null)
                    dgvDisplay.Rows.Add(items);
            }

            dgvDisplay.Refresh();
        }

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

        private string[] GetItems(XElement item)
        {
            return new string[]
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
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;

            if (selectedCells.Count > 0 && dataGridView.CurrentCell.RowIndex < dataGridView.Rows.Count - 1)
            {
                tbEventName.Text = selectedCells[0].Value.ToString();

                string date = selectedCells[1].Value.ToString();
                DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", null);
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
            if(rbEditEvent.Checked)
                EditEvent();
            else if (rbAddEvent.Checked)
                AddEvent();
            else if(rbDeleteEvent.Checked)
                DeleteEvent();

            UpdateDisplay();
        }

        private void DeleteEvent()
        {
            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                if (item.Element("Date").Value == dtpDate.Text && item.Attribute("TITLE").Value == tbEventName.Text)
                    item.Remove();
            }
        }

        private void EditEvent()
        {
            foreach (XElement item in pubsClubs.Element("Gig").Elements("Event"))
            {
                if (item.Element("Date").Value == dtpDate.Text && item.Attribute("TITLE").Value == tbEventName.Text)
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
            XElement newEvent = new XElement("Event",
                new XAttribute("TITLE", tbEventName.Text),
                new XElement("Date", dtpDate.Text),
                new XElement("StartTime", tbStartTime.Text),
                new XElement("EndTime", tbEndTime.Text),
                new XElement("CoverPrice", tbCoverPrice.Text),
                new XElement("AgeLimit", nUpDownAgeLimit.Value),
                new XElement("Club",
                    new XAttribute("ID", 0),
                    new XElement("Name", tbClubName.Text),
                    new XElement("Address", tbClubAddress.Text)
                ),
                new XElement("Band",
                    new XAttribute("ID", 0),
                    new XElement("Name", tbBandName.Text),
                    new XElement("Genre", tbBandGenre.Text)
                )
            );

            pubsClubs.Element("Gig").Add(newEvent);
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if( rb.Text == "Edit Event")
                bAddEvent.Text = "Edit Event";
            else if( rb.Text == "Add Event")
                bAddEvent.Text = "Add Event";
            else if( rb.Text == "Delete Event")
                bAddEvent.Text = "Delete Event";
        }
    }
}
