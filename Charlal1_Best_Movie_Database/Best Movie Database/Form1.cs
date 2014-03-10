using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Best_Movie_Database
{
    public partial class Form1 : Form
    {
        private Dictionary<int, TMovie> movieTable = new Dictionary<int, TMovie>();

        public Form1()
        {
            InitializeComponent();
        }

        private void bAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if textbox fields are valid
                int year = Convert.ToInt16(tbYearAdd.Text);

                String title = tbTitleAdd.Text;
                if (title.Trim() == String.Empty)
                    throw new ArgumentException("Please input the movie title");

                String director = tbDirectorAdd.Text;
                if (director.Trim() == String.Empty)
                    throw new ArgumentException("Please input the movie director");

                // Adds movie to the table
                TMovie movie = new TMovie(year, title, director);
                movieTable.Add(movie.year, movie);

                // Alert for confirmation
                MessageBox.Show("Movie Saved", "Add");

                // Clears the textbox fields
                tbYearAdd.Text = "";
                tbTitleAdd.Text = "";
                tbDirectorAdd.Text = "";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Add");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input the year of the movie", "Add");
            }            
        }
        
        private void bDeleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt16(tbYearDelete.Text);

                if (movieTable.ContainsKey(key))
                {
                    movieTable.Remove(key);
                }
                else
                {
                    MessageBox.Show(key.ToString() + " not found");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input the year of the movie", "Delete");
            } 
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt16(tbYearSearch.Text);

                if (movieTable.ContainsKey(key))
                {
                    TMovie currentMovie = movieTable[key];

                    lbDisplay.Items.Clear();
                    lbDisplay.Items.Add(currentMovie.ToString());
                }
                else
                {
                    MessageBox.Show(key.ToString() + " not found");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input the year of the movie", "Search");
            }            
        }

        private void bPrintAll_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();

            var items = from pair in movieTable orderby pair.Value ascending select pair;

            foreach (KeyValuePair<int, TMovie> movie in items)
            {
                lbDisplay.Items.Add(movie.Value.ToString());
            }           
        }            
    }
}
