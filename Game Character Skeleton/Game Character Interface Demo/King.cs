using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Character_Interface_Demo
{
    class King : GameCharacter, IWeaponBehaviour
    {
        public King(ListBox display, string name) 
            : base(display, name)
        {
            this.kind = "King";
            this.weapon = "sword";
            this.weaponBehaviour = this;
        }

        public string UseWeapon()
        {
            return "I slice with my " + weapon;
        }
    }
}
