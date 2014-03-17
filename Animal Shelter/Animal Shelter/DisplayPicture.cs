using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Animal_Shelter
{
    class DisplayPicture : IDisplayAnimals
    {
        PictureBox[] pbPets;

        public DisplayPicture(PictureBox[] pbPets)
        {
            this.pbPets = pbPets;
        }

        public void display(List<Animal> animals)
        {
            // Adds the animal images to the pictureboxs
            for (int i = 0; i < animals.Count; i++)
                pbPets[i].Image = animals[i].PetImage;
        }
    }
}
