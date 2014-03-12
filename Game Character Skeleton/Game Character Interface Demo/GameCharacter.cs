using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Character_Interface_Demo
{
    class GameCharacter
    {
        private const string STATE_NAME = "My name is ";
        private const string DECLAIM = "I am a ";

        protected string name, kind, weapon;
        protected ListBox display;
        protected IWeaponBehaviour weaponBehaviour;

        public GameCharacter(ListBox display, string name)
        {
            this.name = name;
            this.display = display;
            
        }

        public void DoBattle()
        {
            display.Items.Add(StateName());
            display.Items.Add(Declaim());
            display.Items.Add(weaponBehaviour.UseWeapon());
            display.Items.Add("*************************");
        }

        public string StateName()
        {
            return STATE_NAME + name;
        }

        public string Declaim()
        {
            return DECLAIM + kind;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
