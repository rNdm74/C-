using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldAnimals
{
    /// <summary>
    /// Note: To add a new animal you must modify two classes: AnimalHierachy.cs, FactoryHierachy.cs
    ///       1. Add animal to the AnimalHierachy.cs
    ///       2. Make the appropriate change to the FactoryHierachy.cs
    ///        
    ///       To add a new continent you must modify three classes: Form1, IFormControlManager.cs, FactoryHierachy.cs
    ///       1. Add a new button to the form and name it appropriatly
    ///       2. Add the appropriate "Continent Constant" to IFormControlManager.cs
    ///       3. Add appropriate "if(statement)" to the update() method
    ///       4. Add the approprate factory to FactoryHeirachy.cs adding the animals you want
    ///       
    /// Important: FactoryHeirachy.cs - The MAX_ANIMALS const for each continent MUST match the appropriate continent factory
    /// </summary>
    public partial class Form1 : Form
    {
        //
        // Form controls interface
        private IFormControlManager formControlManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Canvas of the groupbox
            Graphics canvas = gbAnimalImages.CreateGraphics();

            // Instaniate the formControl Manager
            formControlManager = new FormControlManager(canvas, lbDisplayAnimals);
        }

        private void bContinent_Click(object sender, EventArgs e)
        {
            // Get the button
            Button b = (Button)sender;

            // Update the formControlManager with the selectContinent
            formControlManager.update(b.Text);

            // Draw the animals to the screen
            formControlManager.draw();
        }
    }
}
