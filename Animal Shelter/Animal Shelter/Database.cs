using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Animal_Shelter
{
    class Database
    {
        private const char DELIMITER = ',';
        private const int ANIMAL_LIMIT = 4;

        private List<Animal> animalList;
        private IDisplayAnimals displayAnimals;

        public Database(string fileName)
        {
            animalList = createAnimalList(fileName);
        }

        private List<Animal> createAnimalList(string fileName)
        {
            List<Animal> animalList = new List<Animal>();

            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                string animalData = sr.ReadLine();

                Animal animal = new Animal(animalData.Split(DELIMITER));
                
                animalList.Add(animal);
            }

            return animalList;
        }

        public void query(string species, ListBox lbPets, PictureBox[] pbPets)
        {
            // Clear the boxes on each query
            clearListBox(lbPets);
            clearPictureBoxes(pbPets);

            // Display the query
            displayQueryResult(species, lbPets, pbPets);
        }

        private void clearListBox(ListBox lbPets)
        {
            // Listbox
            lbPets.Items.Clear();
        }

        private void clearPictureBoxes(PictureBox[] pbPets)
        {
            // Sets all images in pictureboxes to null
            foreach (var item in pbPets)
                item.Image = null;
        }       

        private void displayQueryResult(string species, ListBox lbPets, PictureBox[] pbPets)
        {
            List<Animal> animalsQuery = new List<Animal>();

            // Trim 's' from the string
            string newString = species.TrimEnd('s');

            // Populate list of selecteed animals
            for (int i = 0; i < animalList.Count; i++)
                if (animalList[i].Species.Contains(newString))
                    animalsQuery.Add(animalList[i]);

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

            displayAnimals.display(animalsQuery);
        }
    }
}
