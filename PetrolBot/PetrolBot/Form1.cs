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
        Ships ship;

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

            // Move Update Draw Simulation Objects
            ship.UpdateState();
            ship.PerformAction();
            ship.Draw(myBuffer.Graphics);

            myBuffer.Render();
            
            myBuffer.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
                                    
            clock.Enabled = true;
            rGen = new Random();
            ship = new Ships(rGen, canvas.Width, canvas.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
