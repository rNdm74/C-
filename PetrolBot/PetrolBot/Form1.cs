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
        private const int SHIPS = 10;
        private const int BOTS = 5;
        
        private EventManager eManager;
        private List<SimulationObject> objects;
        private List<Ship> ships;
        private List<Bot> bots;
        private Random rGen;

        // This example assumes the existence of a form called Form1.
        private BufferedGraphicsContext currentContext;
        private BufferedGraphics myBuffer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;

            // New random generator
            rGen = new Random();
            
            // Make Ships
            ships = new List<Ship>();
            for (int i = 0; i < SHIPS; i++)
                ships.Add(new Ship(rGen, canvas.Width, canvas.Height));
            
            // Make Bots
            bots = new List<Bot>();
            for (int i = 0; i < BOTS; i++)
                bots.Add(new Bot(rGen, canvas.Width, canvas.Height, i * 30));
            
            // Create the eventmanager
            eManager = new EventManager(rGen, bots, ships);

            // Load into objects list for move, update, draw
            objects = new List<SimulationObject>();
            objects.AddRange(ships);
            objects.AddRange(bots);
            
            // Start the timer
            clock.Enabled = true;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            // Make the draw buffer and set background color
            myBuffer = currentContext.Allocate(canvas.CreateGraphics(), canvas.DisplayRectangle);
            myBuffer.Graphics.FillRectangle(Brushes.WhiteSmoke, canvas.DisplayRectangle);

            // Move Update Draw Simulation Objects
            foreach (SimulationObject so in objects)
            {
                so.UpdateState();
                so.PerformAction();
                so.Draw(myBuffer.Graphics);
            }

            // Main draw
            myBuffer.Render();            
            myBuffer.Dispose();
        }        
    }
}
