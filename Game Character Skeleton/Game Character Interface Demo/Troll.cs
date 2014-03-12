using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Character_Interface_Demo
{
    class Troll : GameCharacter, IWeaponBehaviour
    {
        public Troll(ListBox display, string name) 
            : base(display, name)
        {
            this.kind = "Troll";
            this.weapon = "bow";
            this.weaponBehaviour = this;
        }

        public string UseWeapon()
        {
            return "I shoot with my " + weapon;
        }
    }
}
