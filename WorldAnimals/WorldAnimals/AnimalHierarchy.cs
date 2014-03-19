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
                get { return image; } // Read Only
            }

            public override string ToString()
            {
                string displayString = "I am a " + name;
                displayString += ". I am a " + family;
                displayString += ". I eat " + food + ".";
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
                family = "Carnavore";
                food = "Chickens";
                image = new Bitmap("crocodile.jpg");
            } 
        }

        public class Eagle : Animal
        {
            public Eagle()
            {
                name = "Eagle";
                family = "Carnivore";
                food = "Fish";
                image = new Bitmap("eagle.jpg");
            }
        }

        public class Kangaroo : Animal
        {
            public Kangaroo()
            {
                name = "Kangaroo";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("kangaroo.jpg");
            }
        }

        public class Koala : Animal
        {
            public Koala()
            {
                name = "Koala";
                family = "Herbivore";
                food = "Leaves";
                image = new Bitmap("koala.jpg");
            }
        }

        public class Platypus : Animal
        {
            public Platypus()
            {
                name = "Platypus";
                family = "Herbivore";
                food = "Grass";
                image = new Bitmap("platypus.jpg");
            }
        }

        public class Wolf : Animal
        {
            public Wolf()
            {
                name = "Wolf";
                family = "Carnivore";
                food = "Rabbits";
                image = new Bitmap("wolf.jpg");
            }
        }

        public class Snake : Animal
        {
            public Snake()
            {
                name = "Snake";
                family = "Carnivore";
                food = "Mice";
                image = new Bitmap("snake.jpg");
            }
        }

        public class Elephant : Animal
        {
            public Elephant()
            {
                name = "Elephant";
                family = "Herbivore";
                food = "Fruit";
                image = new Bitmap("elephant.jpg");
            }
        }
    }
}
