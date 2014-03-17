using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Animal_Shelter
{
    class DisplayText : IDisplayAnimals
    {
        private ListBox lbPets;

        public DisplayText(ListBox lbPets)
        {
            this.lbPets = lbPets;
        }

        public void display(List<Animal> animals)
        {
            // Add animals to the listbox
            foreach (var animal in animals)
                lbPets.Items.Add(animal.Name + ": " + animal.Species);
        }
    }
}
