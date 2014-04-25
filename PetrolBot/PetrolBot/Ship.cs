using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetrolBot
{
    class Ship : SimulationObject
    {
        public delegate void ShipHandler(object sender, ShipEventArgs se);
        public event ShipHandler NeedsFuelEvent;
        public event ShipHandler RefuelingCompleteEvent;

        private const int FUEL_CAPACITY = 255;
        private const int WANDER_PROB = 400;
        private const int RADIUS = 50;
        private const int MAX_SPEED = 5;
        private const int SPEED_RATIO = 4;

        public float fuel;
        public bool Refueling;

        public Ship(Random rGen, int worldWidth, int worldHeight)
            : base(rGen, worldWidth, worldHeight)
        {
            location = new PointF(rGen.Next(worldWidth - RADIUS), rGen.Next(worldHeight - RADIUS));

            myBrush = new SolidBrush(Color.FromArgb(0, 255, 0));

            state = EObjectState.MOVING;
            
            speed = rGen.Next(1, MAX_SPEED); 
            speed /= SPEED_RATIO;

            fuel = FUEL_CAPACITY;
            radius = RADIUS;
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            g.FillRectangle(myBrush, location.X, location.Y, radius, radius);
        }

        public override void UpdateState()
        {
            switch (state)
            {
                case EObjectState.MOVING:
                    if (fuel <= 0)
                    {
                        state = EObjectState.WAITING;
                    }
                    break;
                case EObjectState.WAITING:
                    if (Refueling)
                    {
                        state = EObjectState.REFUELING;
                    }
                    break;
                case EObjectState.REFUELING:
                    if (fuel >= FUEL_CAPACITY)
                    {
                        OnRefuelingCompleteEvent();
                        state = EObjectState.MOVING;
                    }
                    break;
            }
        }

        public override void PerformAction()
        {
            switch (state)
            {
                case EObjectState.MOVING:
                    if (rGen.Next(WANDER_PROB) == 0)
                    {
                        ChangeRandomDirection();
                    }
                    else
                    {
                        UseFuel();
                        Move(Bearing());
                        Refueling = false;
                    }
                    
                    break;
                case EObjectState.WAITING:
                    OnNeedsFuelEvent();
                    
                    break;
                case EObjectState.REFUELING:
                    ReFuel();
                    break;
            }
        }
        /// <summary>
        /// Updates the color when the ship uses fuel
        /// </summary>
        private void UseFuel()
        {
            // Reduce fuel based on speed
            fuel -= speed;
            // Clamps fuel to zero
            if (fuel < 0) fuel = 0;
            myBrush = new SolidBrush(Color.FromArgb(0, (int)fuel, 0));
        }
        /// <summary>
        /// Updates the color based on the ships refueling
        /// </summary>
        private void ReFuel() 
        {
            // Clamps fuel to 255
            if (fuel > 255) fuel = 255;
            myBrush = new SolidBrush(Color.FromArgb(0, (int)fuel, 0));
        }
        /// <summary>
        /// Event for when a ship needs fuel
        /// </summary>
        public void OnNeedsFuelEvent() 
        {
            ShipEventArgs se = new ShipEventArgs(location);

            if (NeedsFuelEvent != null)
                NeedsFuelEvent(this, se);
        }
        /// <summary>
        /// Event for ship refueling complete
        /// </summary>
        public void OnRefuelingCompleteEvent() 
        {
            ShipEventArgs se = new ShipEventArgs(location);

            if (RefuelingCompleteEvent != null)
                RefuelingCompleteEvent(this, se);
        }
    }

    /// <summary>
    /// Arguments that are accessible when the event is raised
    /// </summary>
    class ShipEventArgs
    {
        private PointF location;
        public PointF Location
        {
            get { return location; }
        }

        public ShipEventArgs(PointF location)
        {
            this.location = location;
        }
    }
}
