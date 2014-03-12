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
        
        //-------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            List<GameCharacter> gameCharacterList = new List<GameCharacter>();

            gameCharacterList.Add(new King(listBox1, "Stewie"));
            gameCharacterList.Add(new Queen(listBox1, "Meg"));
            gameCharacterList.Add(new Knight(listBox1, "Lancelot"));
            gameCharacterList.Add(new Knight(listBox1, "Irving"));
            gameCharacterList.Add(new Troll(listBox1, "Grumpy"));

            foreach (var character in gameCharacterList)
            {
                character.DoBattle();
            }
        } 
    }
}
