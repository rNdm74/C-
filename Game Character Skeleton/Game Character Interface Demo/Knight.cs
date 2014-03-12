using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Character_Interface_Demo
{
    class Knight : GameCharacter, IWeaponBehaviour
    {
        public Knight(ListBox display, string name) 
            : base(display, name)
        {
            this.kind = "Knight";
            this.weapon = "knife";
            this.weaponBehaviour = this;
        }

        public string UseWeapon()
        {
            return "I stab with my " + weapon;
        }
    }
}
