using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetrolBot
{
    class Bot : SimulationObject
    {
        PointF refuelingLocation, homeLocation;
        //RectangleF ship, bot, home;
        public Ship refuelingShip;
        bool shipNeedsFuel;
        public bool isHome;
        public bool isRefueling;

        public Bot(Random rGen, int worldWidth, int worldHeight)
            : base(rGen, worldWidth, worldHeight)
        { 
            speed = 2;
            radius = 20;

            state = EObjectState.WAITING;
            location = new PointF(rGen.Next(100), worldHeight - 40);
            homeLocation = location;

            red = rGen.Next(256);
            green = rGen.Next(256);
            blue = rGen.Next(256);

            myBrush = new SolidBrush(Color.FromArgb(red, green, blue));
        }

        public void Dispatch(Ship ship, PointF location) 
        {
            state = EObjectState.REFUELING;
            refuelingShip = ship;
            isHome = false;
            isRefueling = true;
            shipNeedsFuel = true;
            this.location = location; 
        }

        public void SendHome() 
        {
            refuelingShip = null;
            refuelingLocation = new PointF();
            shipNeedsFuel = false;
            isRefueling = false;
            isHome = true;
            location = homeLocation;
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
                    if (collided(refuelingLocation))
                    {
                        //location = refuelingLocation;
                        //state = EObjectState.REFUELING;
                    }
                    break;
                case EObjectState.WAITING:
                    if(shipNeedsFuel)
                    {
                        //state = EObjectState.MOVING;
                    }
                    break;
                case EObjectState.REFUELING:
                    if (refuelingShip != null && refuelingShip.Refueling == false)
                    {
                        //state = EObjectState.WAITING;
                    }
                    break;
                case EObjectState.RETURN_HOME:
                    if (collided(homeLocation))
                    {
                        //state = EObjectState.WAITING;
                    }
                    break;
            }
        }

        public override void PerformAction()
        {
            switch (state)
            {
                case EObjectState.MOVING:
                    Move(FindAngle(refuelingLocation, location));
                    break;
                case EObjectState.WAITING:
                    isHome = true;
                    break;
                case EObjectState.REFUELING:
                    if (refuelingShip != null) 
                    {
                        refuelingShip.Refueling = true;
                        refuelingShip.fuel+= 5;
                    }   
                    break;
                case EObjectState.RETURN_HOME:
                    //refuelingShip = null;
                    //refuelingLocation = new PointF();

                    //Move(FindAngle(homeLocation, location));
                    break;
            }
        }

        private double FindAngle(PointF destination, PointF source)
        {
            double dx = destination.X - source.X;
            double dy = destination.Y - source.Y;
            return Math.Atan2(dy, dx) * (180 / Math.PI);
        }

        private bool collided(PointF destLocation)
	    {
		    bool collided = true;

		    float s1XPos = location.X;
            float s1YPos = location.Y;

            float s2XPos = destLocation.X;
            float s2YPos = destLocation.Y;

		    RectangleF s1 = new RectangleF(s1XPos, s1YPos, radius, radius);
            RectangleF s2 = new RectangleF(s2XPos, s2YPos, 50, 50);

		    if(s1.Bottom  < s2.Top)	 collided = false;
		    if(s1.Top > s2.Bottom)	 collided = false;
		    if(s1.Right < s2.Left)	 collided = false;
		    if(s1.Left > s2.Right)	 collided = false;

		    return collided;	
	    }
    }
}
