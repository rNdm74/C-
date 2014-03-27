using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mix_and_Match
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// To add a new Character
        /// add the name to the CHARACTERS array 
        /// add your image to the debug folder
        /// </summary>
        private string[] CHARACTERS = new string[] 
        {
            "Fairy", 
            "Frankenstein", 
            "Skeleton", 
            "Vampire", 
            "Werewolf", 
            "Witch" 
        };

        private MakerFactory makerFactory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initMonster();
            makeMonster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeMonster();
        }

        private void initMonster()
        {
            // Instaniate the factory
            makerFactory = new MakerFactory();

            // Add characters to the combo boxes
            foreach (var character in CHARACTERS)
            {
                cbHead.Items.Add(character);
                cbBody.Items.Add(character);
                cbLegs.Items.Add(character);
            }

            // Display the first item in collection 
            cbHead.Text = (string)cbHead.Items[0];
            cbBody.Text = (string)cbBody.Items[0];
            cbLegs.Text = (string)cbLegs.Items[0];
        }

        private void makeMonster()
        {
            // Loads the images of body parts to the pictureboxs
            pbHead.Image = makerFactory.createCharacterMaker(cbHead.Text).HeadImage();
            pbBody.Image = makerFactory.createCharacterMaker(cbBody.Text).BodyImage();
            pbLegs.Image = makerFactory.createCharacterMaker(cbLegs.Text).LegsImage();
        }
    }
}
