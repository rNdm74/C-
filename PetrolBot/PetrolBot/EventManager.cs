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
            bool botsAtHome = false;
            int count = 0;
            while (count < bots.Count && botsAtHome == false)
            {
                if (bots[count].isHome)
                    botsAtHome = true;

                count++;
            }

            if (botsAtHome) 
            {
                bool pickedBot = false;
                int selectedBotFromPool = rGen.Next(bots.Count);
                while (pickedBot == false)
                {
                    if (!bots[selectedBotFromPool].isRefueling && bots[selectedBotFromPool].isHome)
                    {
                        pickedBot = true;
                        bots[selectedBotFromPool].Dispatch((Ship)sender, se.Location);
                    }
                    else
                    {
                        selectedBotFromPool = rGen.Next(bots.Count);
                    }
                }
            }

            
        }
        private void refuelingCompleteHandler(object sender, ShipEventArgs se)
        {
            foreach (Bot bot in bots)
            {
                if (bot.refuelingShip != null && bot.refuelingShip.Equals((Ship)sender))
                {
                    bot.SendHome();
                }
            }
        }
    }
}
