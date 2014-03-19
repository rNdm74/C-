using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldAnimals
{
    //=======================================================
    // Increase if you add more animals to the factory
    //=======================================================
    struct MAX_ANIMALS
    {
        public const int AUSTALIA        = 4;
        public const int NORTH_AMERICA   = 4;
        public const int AFRICA          = 1;
    }

    class FactroyHierarchy
    {
        //=======================================================
        // Base Interface
        //=======================================================
        public interface IAnimalFactory
        {
            AnimalHierarchy.Animal createAnimal(Random rGen);
        }

        //=======================================================
        // North American Factory
        //=======================================================
        public class NorthAmericanAnimalFactory : IAnimalFactory
        {
            public AnimalHierarchy.Animal createAnimal(Random rGen)
            {
                AnimalHierarchy.Animal animal = null;

                switch (rGen.Next(MAX_ANIMALS.NORTH_AMERICA))
                {
                    case 0:
                        animal = new AnimalHierarchy.Bison();
                        break;
                    case 1:
                        animal = new AnimalHierarchy.Eagle();
                        break;
                    case 2:
                        animal = new AnimalHierarchy.Platypus();
                        break;
                    case 3:
                        animal = new AnimalHierarchy.Wolf();
                        break;
                }

                return animal;
            }
        }

        //=======================================================
        // Australian Factory
        //=======================================================
        public class AustralianAnimalFactory : IAnimalFactory
        { 
            public AnimalHierarchy.Animal createAnimal(Random rGen)
            {
                AnimalHierarchy.Animal animal = null;

                switch (rGen.Next(MAX_ANIMALS.AUSTALIA))
                {
                    case 0:
                        animal = new AnimalHierarchy.Kangaroo();
                        break;
                    case 1:
                        animal = new AnimalHierarchy.Crocodile();
                        break;
                    case 2:
                        animal = new AnimalHierarchy.Koala();
                        break;
                    case 3:
                        animal = new AnimalHierarchy.Snake();
                        break;
                }

                return animal;
            }
        }

        //=======================================================
        // African Factory
        //=======================================================
        public class AfricanAnimalFactory : IAnimalFactory
        {
            public AnimalHierarchy.Animal createAnimal(Random rGen)
            {
                AnimalHierarchy.Animal animal = null;

                switch (rGen.Next(MAX_ANIMALS.AFRICA))
                {
                    case 0:
                        animal = new AnimalHierarchy.Elephant();
                        break;                    
                }

                return animal;
            }
        }
    }
}
