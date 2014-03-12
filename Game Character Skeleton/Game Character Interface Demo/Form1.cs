using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Character_Interface_Demo
{
    public partial class Form1 : Form
    {
        private List<GameCharacter> gameCharacterList;

        //-------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {

            foreach (var character in checkedListBox1.SelectedItems)
            {
                ((GameCharacter)character).DoBattle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameCharacterList = new List<GameCharacter>();

            gameCharacterList.Add(new King(listBox1, "Stewie"));
            gameCharacterList.Add(new Queen(listBox1, "Meg"));
            gameCharacterList.Add(new Knight(listBox1, "Lancelot"));
            gameCharacterList.Add(new Knight(listBox1, "Irving"));
            gameCharacterList.Add(new Troll(listBox1, "Grumpy"));

            checkedListBox1.Items.AddRange(gameCharacterList.ToArray());
            checkedListBox2.Items.AddRange(gameCharacterList.ToArray());
        } 
    }
}
