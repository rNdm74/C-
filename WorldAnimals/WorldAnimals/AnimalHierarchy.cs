using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WorldAnimals
{
    public class AnimalHierarchy
    {
        //=======================================================
        // Base Class
        //=======================================================
        public abstract class Animal
        {
            protected string name;
            protected string family;
            protected string food;
            protected Bitmap image;
            public Bitmap Image
            {
                get 
                {
                    return image; // Read Only
                }
            }

            public override string ToString()
            {
                string displayString = "I am " + name;
                displayString += ". I am a " + family;
                displayString += "I eat " + food + ".";
                return displayString;
            }
        }

        //=======================================================
        // Children Classes
        //=======================================================
        public class Bison : Animal 
        {
            public Bison()
            {
                name = "Bison";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("bison.jpg");
            }
            

        }

        public class Crocodile : Animal
        {
            public Crocodile()
            {
                name = "Croc";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("bison.jpg");
            } 
        }

        public class Eagle : Animal
        {
            public Eagle()
            {
                name = "Eagle";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("bison.jpg");
            }
        }

        public class Kangaroo : Animal
        {
            public Kangaroo()
            {
                name = "Kangaroo";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("bison.jpg");
            }
        }

        public class Koala : Animal
        {
            public Koala()
            {
                name = "Koala";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("bison.jpg");
            }
        }

        public class Platypus : Animal
        {
            public Platypus()
            {
                name = "Platypus";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("bison.jpg");
            }
        }

        public class Wolf : Animal
        {
            public Wolf()
            {
                name = "Wolf";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("wolf.jpg");
            }
        }
    }
}
