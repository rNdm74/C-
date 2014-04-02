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
        private List<Garden> gardenList;
        public List<Garden> GardenList
        {
            get { return gardenList; }
            set { gardenList = value; }
        }

        public GardenManager() 
        {
            gardenList = new List<Garden>();
        }

        public void AddGarden(Garden newGarden)
        {
            gardenList.Add(newGarden);
        }

        public string AreaReporter(Garden currentGarden)
        {
            string reportString = "";

            reportString = String.Format("{0,-14}:{1,8:f2}", currentGarden.OwnerName, currentGarden.GetArea());

            return reportString;
        }

        public string ChargesReporter(Garden currentGarden)
        {
            string reportString = "";

            reportString = String.Format("{0,-14}:  {1,8:c2}", currentGarden.OwnerName, currentGarden.GetAccountBalance());

            return reportString;
        }
    }
}
