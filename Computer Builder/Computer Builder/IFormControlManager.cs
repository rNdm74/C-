using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Builder
{
    interface IFormControlManager
    {        
        void update(string selectedContinent);
        void draw();
    }

    //======================================================================
    // Modify when adding new continent: Continent Constants, Update method
    //======================================================================
    public class FormControlManager : IFormControlManager
    {
        // Continent Constants
        private const string    NORTH_AMERICA           = "North America";
        private const string    AUSTRALIA               = "Australia";
        private const string    AFRICA                  = "Africa";
        // Draw Constants
        private const int       MAX_DISPLAY_ANIMALS     = 4;
        private const int       X                       = 20;
        private const int       Y                       = 20;
        private const int       WIDTH                   = 150;
        private const int       HEIGHT                  = 100;
        
        // Variables
        private Random rGen;
        private Graphics canvas;
        private ListBox listBox;  
      
        //private FactroyHierarchy.IAnimalFactory animalFactory;

        public FormControlManager(ListBox listBox)
        {
            this.rGen = new Random();
            this.listBox = listBox; 
        }

        //=======================================================================
        // If extra continents need to be added please add another if(statement) 
        //=======================================================================
        public void update(COMPUTER computerType)
        {
            listBox.Items.Clear();

            switch (computerType)
            {
                case COMPUTER.BUSINESS:
                    computerFactory = new 
                    break;
                case COMPUTER.GAMING:
                    break;
                case COMPUTER.MEDIA:
                    break;
            }     
        }

        public void draw()
        {
            for (int i = 0; i < MAX_DISPLAY_ANIMALS; i++)
            {
                // Create an animal based on contenint
                AnimalHierarchy.Animal animal = animalFactory.createAnimal(rGen);
                // Add to listbox
                listBox.Items.Add(animal.ToString());
                // Draw its image vertically
                canvas.DrawImage(animal.Image, X, Y + (HEIGHT * i), WIDTH, HEIGHT);
            }
        }
    }
}
