using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetrolBot
{
    class EventManager
    {
        private Random rGen;
        private List<Bot> bots;
        private List<Ship> ships;
        private List<Bot> botsPool;

        public EventManager(Random rGen, List<Bot> bots, List<Ship> ships)
        {
            this.rGen = rGen;
            this.bots = bots;
            this.ships = ships;

            foreach (Ship ship in ships)
            {
                ship.NeedsFuelEvent += new Ship.ShipHandler(needFuelHandler);
                ship.RefuelingCompleteEvent += new Ship.ShipHandler(refuelingCompleteHandler);
            }
        }

        private void needFuelHandler(object sender, ShipEventArgs se)
        {
            bool pickedBot = false;
            int selectedBotFromPool = rGen.Next(bots.Count);
            while (pickedBot == false)
            {
                if (bots[selectedBotFromPool].isHome)
                {
                    pickedBot = true;
                    bots[selectedBotFromPool].Dispatch((Ship)sender, se.Location);
                }
                else 
                {
                    selectedBotFromPool = rGen.Next(bots.Count); 
                }
            }

            


            //bots[se.ID].Dispatch((Ship)sender, se.Location);
        }
        private void refuelingCompleteHandler(object sender, ShipEventArgs se)
        {
            bots[se.ID].SendHome();
        }
    }
}
