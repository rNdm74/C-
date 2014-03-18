using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Shelter
{
    class Database : IDatabase<Animal>
    {
        private List<Animal> animalDB;

        public Database() 
        {
            animalDB = new List<Animal>();
        }

        public int Count()
        {
            return animalDB.Count;
        }

        public void Add(Animal t)
        {
            animalDB.Add(t);
        }

        public void Delete(Animal t)
        {
            animalDB.Remove(t);
        }

        public void Modify(int i, Animal t)
        {
            // Removes the animal
            animalDB.RemoveAt(i);
            // Adds the new Animal 
            animalDB.Insert(i, t);
        }

        List<Animal> IDatabase<Animal>.Search(string searchString)
        {
            // Create list for search results
            List<Animal> results = new List<Animal>();

            for (int i = 0; i < animalDB.Count; i++)
            {
                // Get the species name
                string species = animalDB[i].Species;

                // Add to results if found
                if (species.Contains(searchString))
                    results.Add(animalDB[i]);
            }

            return results;
        }
    }
}
