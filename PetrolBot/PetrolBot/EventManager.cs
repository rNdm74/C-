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

            // Add the events to the ships
            foreach (Ship ship in ships)
            {
                ship.NeedsFuelEvent += new Ship.ShipHandler(needFuelHandler);
                ship.RefuelingCompleteEvent += new Ship.ShipHandler(refuelingCompleteHandler);
            }
        }
        /// <summary>
        /// Event raised when a ship needs fuel, will select a waiting bot and dispatch them to the ship
        /// </summary>
        /// <param name="sender">Ship</param>
        /// <param name="se">fuel, ID</param>
        private void needFuelHandler(object sender, ShipEventArgs se)
        {
            if (isBotsReadyForRefueling()) 
            {
                Bot botForRefueling = selectBotForRefueling();
                botForRefueling.Dispatch((Ship)sender, se.Location);
            }
        }
        /// <summary>
        /// Returns a random bot waiting to refuel a ship
        /// </summary>
        /// <returns>Bot</returns>
        private Bot selectBotForRefueling() 
        {
            int selectedBotFromPool = rGen.Next(bots.Count);

            while (bots[selectedBotFromPool].isHome == false || bots[selectedBotFromPool].isRefueling)
                selectedBotFromPool = rGen.Next(bots.Count);

            return bots[selectedBotFromPool];
        }
        /// <summary>
        /// Returns true if there are bots waiting to refuel ship
        /// </summary>
        /// <returns>false on default</returns>
        private bool isBotsReadyForRefueling() 
        {
            int count = 0;

            while (count < bots.Count && bots[count].isHome)
                count++;

            return count > 0;
        }
        /// <summary>
        /// Find the bot that serviced the ship that rasied the event and send home
        /// </summary>
        /// <param name="sender">Ship</param>
        /// <param name="se">fuel, ID</param>
        private void refuelingCompleteHandler(object sender, ShipEventArgs se)
        {
            foreach (Bot bot in bots)
                if (bot.refuelingShip != null && bot.refuelingShip.Equals((Ship)sender))
                    bot.SendHome();
        }
    }
}
