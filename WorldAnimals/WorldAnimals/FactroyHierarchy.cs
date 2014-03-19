using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldAnimals
{
    class FactroyHierarchy
    {
        //=======================================================
        // Base Interface
        //=======================================================
        interface IAnimalFactory
        {
            AnimalHierarchy.Animal createAnimal(int AnimalType);
        }

        //=======================================================
        // Impliemented Factory Interfaces
        //=======================================================
        class AustralianAnimalFactory : IAnimalFactory
        {
            public AnimalHierarchy.Animal createAnimal(int AnimalType)
            {
                AnimalHierarchy.Animal animal = null;

                switch (AnimalType)
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
                }

                return animal;
            }
        }

        class NorthAmericanAnimalFactory : IAnimalFactory
        {
            public AnimalHierarchy.Animal createAnimal(int AnimalType)
            {
                AnimalHierarchy.Animal animal = null;

                switch (AnimalType)
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
                }

                return animal;
            }
        }
    }
}
