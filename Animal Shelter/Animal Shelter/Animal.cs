using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Animal_Shelter
{
    enum ANIMAL { NAME = 0, SPECIES = 1 }

    class Animal
    {  
        private string name, species;
        private Image image;

        /// <summary>
        /// GET AND SETS
        /// </summary>
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
            }
        }
        public Image PetImage
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="animalData"></param>
        public Animal(string[] animalData)
        {
            this.name = animalData[(int)ANIMAL.NAME];
            this.species = animalData[(int)ANIMAL.SPECIES];
            this.image = loadImage();
        }

        private Image loadImage() 
        {
            try
            {
                return Image.FromFile(@"images/" + name + ".jpg");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
