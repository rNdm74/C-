using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Garden_Reporter_2013
{
    class GardenManager
    {
        //====================================================
        // Private data fields
        //====================================================
        private List<Garden> gardenList;

        //====================================================
        // Public data property
        //====================================================
        public List<Garden> GardenList
        {
            get { return gardenList; }
            set { gardenList = value; }
        }

        //====================================================
        // Constructor
        //====================================================
        public GardenManager() 
        {
            gardenList = new List<Garden>();
        }

        //====================================================
        // Add new garden to the manager list
        //====================================================
        public void AddGarden(Garden newGarden)
        {
            gardenList.Add(newGarden);
        }

        //====================================================
        // Reports the area of the currently selected garden
        //====================================================
        public string AreaReporter(Garden currentGarden)
        {
            string reportString = "";

            reportString = String.Format("{0,-14}:{1,8:f2}", currentGarden.OwnerName, currentGarden.GetArea());

            return reportString;
        }

        //====================================================
        // Reports the charges of the currently selected garden
        //====================================================
        public string ChargesReporter(Garden currentGarden)
        {
            string reportString = "";

            reportString = String.Format("{0,-14}:  {1,8:c2}", currentGarden.OwnerName, currentGarden.GetAccountBalance()); // Need the spaces after the colon to pass the test

            return reportString;
        }
    }
}
