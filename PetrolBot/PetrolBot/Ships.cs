using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetrolBot
{
    class Ships : SimulationObject
    {
        private const int FUEL_CAPACITY = 255;

        private int fuel;
        private bool refueling;

        public Ships(Random rGen, int worldWidth, int worldHeight)
            : base(rGen, worldWidth, worldHeight)
        {
            fuel = FUEL_CAPACITY;

            state = EObjectState.MOVING;
        }



        public override void UpdateState()
        {
            switch (state)
            {
                case EObjectState.MOVING:
                    if (fuel <= 0)
                    {
                        state = EObjectState.REFUELING;
                    }
                    break;
                case EObjectState.WAITING:
                    if (refueling)
                    {
                        state = EObjectState.REFUELING;
                    }
                    break;
                case EObjectState.REFUELING:
                    if (fuel >= FUEL_CAPACITY)
                    {
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
                    UseFuel();
                    Move();
                    break;
                case EObjectState.WAITING:
                    //stateColor = Brushes.Red;
                    
                    break;
                case EObjectState.REFUELING:
                    ReFuel();
                    break;
                default:
                    break;
            }
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            g.FillRectangle(myBrush, location.X, location.Y, 50, 50);
        }

        private void UseFuel()
        {
            fuel -= 1;

            red++;
            green--;
            myBrush = new SolidBrush(Color.FromArgb(red, green, blue));
        }

        private void ReFuel() 
        {
            fuel += 1;

            red--;
            green++;
            myBrush = new SolidBrush(Color.FromArgb(red, green, blue));
        }
    }
}
