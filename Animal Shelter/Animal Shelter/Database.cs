using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Shelter
{
    class Database : IDatabase<Animal>
    {
        private List<Animal> data = new List<Animal>();
        
        public int Count()
        {
            return data.Count;
        }

        public void Add(Animal t)
        {
            data.Add(t);
        }

        public void Delete(Animal t)
        {
            data.Remove(t);
        }

        public void Modify(int i, Animal t)
        {
            // Removes item
            data.RemoveAt(i);
            // Replaces with new item
            data.Insert(i, t);
        }

        List<Animal> IDatabase<Animal>.Search(string s)
        {
            // Create list for search results
            List<Animal> results = new List<Animal>();
            
            for (int i = 0; i < data.Count; i++)
            {
                // Get the species name
                string key = data[i].Species;

                // Add to results if found
                if (key.Contains(s))
                    results.Add(data[i]);
            }

            return results;
        }
    }
}
