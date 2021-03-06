﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animal_Shelter
{
    public partial class Form1 : Form
    {
        // CONSTANTS
        private const string    ANIMAL_LIST     = "animalList.txt";
        private const int       ANIMAL_LIMIT    = 4;
        private const char      DELIMITER       = ',';
        private const char      TRIM_CHAR       = 's';

        // Variables
        private IDatabase<Animal> db;
        private IDisplayAnimals displayAnimals;
        
        // Arrays
        private PictureBox[] pbPets;
        private RadioButton[] rbSelect;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load form controls into an array
            rbSelect = new RadioButton[] { rbCats, rbDogs, rbDucks, rbRabbits };
            pbPets = new PictureBox[] { pbPet1, pbPet2, pbPet3, pbPet4 };
            
            // Create a new database
            db = new Database();

            // Add Animals to database
            addAnimalsToDatabase(ANIMAL_LIST);
        }

        private void addAnimalsToDatabase(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);

                // While there is something to read
                while (!sr.EndOfStream)
                {
                    // Get the line
                    string animalData = sr.ReadLine();

                    // Create the animal
                    Animal animal = new Animal(animalData.Split(DELIMITER));

                    // Add to database
                    db.Add(animal);
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show(e.Message, "The file could not be read");
                Application.Exit();
            }
        }

        private void bShowPets_Click(object sender, EventArgs e)
        {
            // Clear the boxes on each query
            clearFormControls();

            // Get selected species for search
            string search = selectedSpecies(rbSelect);

            // Display results
            displayQueryResult(search);
        }

        private void clearFormControls()
        {
            // Sets all images in pictureboxes to null
            foreach (var item in pbPets)
                item.Image = null;

            // Clear Listbox
            lbPets.Items.Clear();
        }
        
        private string selectedSpecies(RadioButton[] rbSelect)
        {
            int count = 0;

            // Finds the checked radiobutton
            while (!rbSelect[count].Checked)
                count++;

            // Returns its name
            return rbSelect[count].Text;
        }

        private void displayQueryResult(string species)
        {
            // Trim 's' from the string
            string key = species.TrimEnd(TRIM_CHAR);

            // Populate list of selected animals
            List<Animal> animalsQuery = db.Search(key);

            // Determines how many animals in selection
            if (animalsQuery.Count > ANIMAL_LIMIT)
            {
                // Display listbox
                displayAnimals = new DisplayText(lbPets);
            }
            else
            {
                // Display pictureboxes
                displayAnimals = new DisplayPicture(pbPets);
            }

            // Display
            displayAnimals.display(animalsQuery);
        }
    }
}
