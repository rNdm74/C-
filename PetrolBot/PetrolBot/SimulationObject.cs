using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetrolBot
{
    enum EObjectState 
    {
        MOVING, WAITING, REFUELING
    }

    abstract class SimulationObject
    {
        int speed;

        int angle;
        int radius;

        Random rGen;

        int worldWidth, worldHeight;

        protected int red, blue, green;

        protected PointF location;

        protected EObjectState state;

        protected SolidBrush myBrush = new SolidBrush(Color.Blue);

        public SimulationObject(Random rGen, int worldWidth, int worldHeight) 
        {
            this.rGen = rGen;
            this.worldWidth = worldWidth;
            this.worldHeight = worldHeight;

            ChangeRandomDirection();
            speed = 1;
            radius = 50;

            red = 0;
            green = 255;
            blue = 0;

            myBrush = new SolidBrush(Color.FromArgb(red,green,blue));

        }

        public abstract void UpdateState();
        public abstract void PerformAction();
        public abstract void Draw(Graphics g);

        protected void Move()
	    {
		    double radiansAngle = angle * 0.01745; // convert degrees to radians PI / 180

		    if(location.X < 0 || location.X + radius > worldWidth || location.Y < 0 || location.Y + radius > worldHeight)
		    {
			    location.X -= (float) Math.Cos(radiansAngle) * speed;
			    location.Y -= (float) Math.Sin(radiansAngle) * speed;

			    ChangeRandomDirection();
		    }
		    else
		    {
			    location.X += (float) Math.Cos(radiansAngle) * speed;
                location.Y += (float) Math.Sin(radiansAngle) * speed;
		    }		
	    }

        protected void ChangeRandomDirection()
	    {
		    int newAngle = rGen.Next(361);

		    angle = newAngle;
	    }
    }
}
