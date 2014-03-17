using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animal_Shelter
{
    public partial class Form1 : Form
    {
        private const string ANIMALLIST = "animalList.txt";
        
        private RadioButton[] selectedSpecies;
        private PictureBox[] animalPictureBoxes;
        private Database database;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database = new Database(ANIMALLIST);
            selectedSpecies = new RadioButton[]{ rbCats, rbDogs, rbDucks, rbRabbits };
            animalPictureBoxes = new PictureBox[] { pbPet1, pbPet2, pbPet3, pbPet4 };
        }

        private void bShowPets_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (!selectedSpecies[count].Checked)
            {
                count++;
            }

            database.displayAnimalList(selectedSpecies[count].Text);
        }
    }
}
