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
        private const string KING = "King";
        private const string QUEEN = "Queen";
        private const string KNIGHT = "Knight";
        private const string TROLL = "Troll";

        private List<GameCharacter> gameCharacterList;
        private RadioButton[] charaterRadioButtons;
        private RadioButton[] weaponRadioButtons;
        
        //-------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            int count = 0;
            string type = "";

            foreach (var item in charaterRadioButtons)
            {
                if (item.Checked)
                {
                    type = item.Text;
                    count++;
                }
            }

            // Error checking if textbox is empty
            if (txtName.Text.Equals(""))
                MessageBox.Show("Please type in a character name", "Character Name");
            // Error checking if checkbox is empty
            if(count <= 0)
                MessageBox.Show("Please choose a character type", "Choose Character");
            else
                gameCharacterList.Add(createCharacter(type, txtName.Text));

            updateCheckedListBoxes();
        }

        private GameCharacter createCharacter(string characterType, string name)
        {
            if (characterType.Equals(KING))
                return new King(listBox1, name);

            if (characterType.Equals(QUEEN))
                return new Queen(listBox1, name);

            if (characterType.Equals(KNIGHT))
                return new Knight(listBox1, name);

            if (characterType.Equals(TROLL))
                return new Troll(listBox1, name);

            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string weapon = "";

            foreach (var item in weaponRadioButtons)
            {
                if (item.Checked)
                {
                    weapon = item.Text;
                    count++;
                }
            }

            // Error checking if checkbox is empty
            if (count <= 0)
            {
                MessageBox.Show("Please choose a character weapon", "Choose Weapon");
            }
            else
            {
                GameCharacter character = ((GameCharacter)checkedListBox2.SelectedItem);
                character.Weapon = weapon;
                MessageBox.Show(character.Name + " changed weapon to " + weapon, "Weapon changed");
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Next show the object title and check state for each item selected. 
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                ((GameCharacter)itemChecked).DoBattle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createGameCharacters();
            setupGameRadioButtons();
            updateCheckedListBoxes();
        }

        private void createGameCharacters()
        {
            gameCharacterList = new List<GameCharacter>();
            gameCharacterList.Add(new King(listBox1, "Stewie"));
            gameCharacterList.Add(new Queen(listBox1, "Meg"));
            gameCharacterList.Add(new Knight(listBox1, "Lancelot"));
            gameCharacterList.Add(new Knight(listBox1, "Irving"));
            gameCharacterList.Add(new Troll(listBox1, "Grumpy"));
        }

        private void setupGameRadioButtons()
        {
            charaterRadioButtons = new RadioButton[]
            {
                rdKing, rdQueen, rdKnight, rdTroll
            };

            weaponRadioButtons = new RadioButton[]
            {
                rdBow, rdKnife, rdSword
            };
        }

        private void updateCheckedListBoxes()
        {
            // Update checkedListBox1
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(gameCharacterList.ToArray());
            // Update checkListBox2
            checkedListBox2.Items.Clear();
            checkedListBox2.Items.AddRange(gameCharacterList.ToArray());
        }
    }
}
