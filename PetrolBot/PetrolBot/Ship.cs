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
        private const int WANDER_PROB = 500;
        public int fuel;
        private int waitingTime;
        public bool Refueling;
        private int id;

        public Ship(int id, Random rGen, int worldWidth, int worldHeight)
            : base(rGen, worldWidth, worldHeight)
        {
            this.id = id;

            speed = rGen.Next(1, 5);
            radius = 50;

            fuel = FUEL_CAPACITY;
            waitingTime = 500;

            state = EObjectState.MOVING;

            red = 0;
            green = 255;
            blue = 0;

            myBrush = new SolidBrush(Color.FromArgb(red, green, blue));
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            g.FillRectangle(Brushes.Black, location.X, location.Y, radius, radius);
            g.DrawString(fuel.ToString(), new Font("Verdana", 12), myBrush, new PointF(location.X, location.Y + 30));
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
                    break;
            }
        }

        private void UseFuel()
        {
            fuel -= speed;

            //red++;
            //green--;
            //myBrush = new SolidBrush(Color.FromArgb(red, green, blue));
        }

        private void ReFuel() 
        {
            //fuel += 1;

            //red--;
            //green++;
            //myBrush = new SolidBrush(Color.FromArgb(red, green, blue));
        }

        public void OnNeedsFuelEvent() 
        {
            ShipEventArgs se = new ShipEventArgs(id, location);

            if (NeedsFuelEvent != null)
                NeedsFuelEvent(this, se);
        }

        public void OnRefuelingCompleteEvent() 
        {
            ShipEventArgs se = new ShipEventArgs(id, location);

            if (RefuelingCompleteEvent != null)
                RefuelingCompleteEvent(this, se);
        }

        //public void StartRefueling()
        //{
        //    OnShipEvent();
        //}
    }

    class ShipEventArgs
    {
        private PointF location;
        public PointF Location
        {
            get { return location; }
        }
        private int id;
        public int ID
        {
            get { return id; }
        }

        public ShipEventArgs(int id, PointF location)
        {
            this.id = id;
            this.location = location;
        }
    }
}
