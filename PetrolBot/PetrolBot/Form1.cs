using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolBot
{
    public partial class Form1 : Form
    {
        Random rGen;
        EventManager eManager;
        List<Ship> ships;
        List<Bot> bots;
        List<SimulationObject> objects;

        // This example assumes the existence of a form called Form1.
        private BufferedGraphicsContext currentContext;
        private BufferedGraphics myBuffer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            myBuffer = currentContext.Allocate(canvas.CreateGraphics(), canvas.DisplayRectangle);
            myBuffer.Graphics.FillRectangle(Brushes.WhiteSmoke, canvas.DisplayRectangle);

            // Move Update Draw Simulation Objects
            foreach (SimulationObject so in objects)
            {
                so.UpdateState();
                so.PerformAction();
                so.Draw(myBuffer.Graphics);
            }

            myBuffer.Render();
            
            myBuffer.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
                                    
            clock.Enabled = true;

            rGen = new Random();

            
            objects = new List<SimulationObject>();
            ships = new List<Ship>();
            ships.Add(new Ship(1, rGen, canvas.Width, canvas.Height));
            ships.Add(new Ship(2, rGen, canvas.Width, canvas.Height));
            ships.Add(new Ship(3, rGen, canvas.Width, canvas.Height));

            bots = new List<Bot>();
            bots.Add(new Bot(rGen, canvas.Width, canvas.Height));
            bots.Add(new Bot(rGen, canvas.Width, canvas.Height));
            //bots.Add(new Bot(rGen, canvas.Width, canvas.Height));
            //bots.Add(new Bot(rGen, canvas.Width, canvas.Height));

            eManager = new EventManager(rGen, bots, ships);
            
            objects.AddRange(ships);
            objects.AddRange(bots);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
