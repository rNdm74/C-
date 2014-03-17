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
        
        private RadioButton[] selected;
        private PictureBox[] pbPets;
        private Database database;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load form controls into an array
            selected = new RadioButton[] { rbCats, rbDogs, rbDucks, rbRabbits };
            pbPets = new PictureBox[] { pbPet1, pbPet2, pbPet3, pbPet4 };
            // Create a new database
            database = new Database(ANIMALLIST);
        }

        private void bShowPets_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (!selected[count].Checked)
                count++;

            string selectedSpecies = selected[count].Text;

            database.query(selectedSpecies, lbPets, pbPets);
        }
    }
}
