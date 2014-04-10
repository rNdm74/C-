using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetrolBot
{
    class Bot : SimulationObject
    {
        private const int RADIUS = 20;
        private const int REFUEL_RATE = 5;

        private PointF homeLocation;
        public bool isHome, isRefueling;
        public Ship refuelingShip;
        
        public Bot(Random rGen, int worldWidth, int worldHeight, int startX)
            : base(rGen, worldWidth, worldHeight)
        {
            myBrush = new SolidBrush(Color.FromArgb(rGen.Next(256), rGen.Next(256), rGen.Next(256)));
            location = new PointF(startX, worldHeight - RADIUS);
            homeLocation = location;
            radius = RADIUS;
            isHome = true;
        }
        /// <summary>
        /// Dispatches the bot when a ship fires the refuel event
        /// </summary>
        /// <param name="ship">Ship the fired the event</param>
        /// <param name="location">Location of the ship that fired the event</param>
        public void Dispatch(Ship ship, PointF location) 
        {
            state = EObjectState.REFUELING;
            
            refuelingShip = ship;
            isRefueling = true;
            isHome = false;

            this.location = location;
        }
        /// <summary>
        /// Initiate the send home after the fueling is complete
        /// </summary>
        public void SendHome() 
        {            
            refuelingShip = null;
            isRefueling = false;
            isHome = true;

            location = homeLocation;
        }
        /// <summary>
        /// Draws to the canvas
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(System.Drawing.Graphics g)
        {
            g.FillRectangle(myBrush, location.X, location.Y, radius, radius);
        }
        /// <summary>
        /// This is redundant
        /// </summary>
        public override void UpdateState()
        {
            switch (state)
            {                
                case EObjectState.WAITING:                    
                    break;
                case EObjectState.REFUELING:                    
                    break;
            }
        }
        /// <summary>
        /// Performs the refueling of the ship
        /// </summary>
        public override void PerformAction()
        {
            switch (state)
            {
                case EObjectState.REFUELING:
                    if (refuelingShip != null) 
                    {
                        refuelingShip.Refueling = true;
                        refuelingShip.fuel += REFUEL_RATE;
                    }   
                    break;
            }
        }
    }
}
