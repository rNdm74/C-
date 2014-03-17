using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Animal_Shelter
{
    class Database
    {
        private const char DELIMITER = ',';
        private const int ANIMAL_LIMIT = 4;

        List<Animal> animalList;

        IDisplayAnimals displayAnimals;

        public Database(string fileName)
        {
            animalList = createAnimalList(fileName);
        }

        private List<Animal> createAnimalList(string fileName)
        {
            try
            {
                List<Animal> animalList = new List<Animal>();

                StreamReader sr = new StreamReader(fileName);

                while (!sr.EndOfStream)
                {
                    string animalData = sr.ReadLine();

                    animalList.Add(new Animal(animalData.Split(DELIMITER)));
                }

                return animalList;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public List<Animal> displayAnimalList(string species)
        {
            List<Animal> animals = new List<Animal>();

            foreach (var animal in animalList)
                if(animal.Species.Equals(species))
                    animals.Add(animal);

            if (animals.Capacity > ANIMAL_LIMIT)
            {
                // Display listbox
                displayAnimals = new DisplayText();
            }
            else
            {
                // Display pictureboxes
                displayAnimals = new DisplayPicture();
            }

            return animalList;
        }
    }
}
