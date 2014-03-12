using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Character_Interface_Demo
{
    class Queen : GameCharacter, IWeaponBehaviour
    {
        public Queen(ListBox display, string name) 
            : base(display, name)
        {
            this.kind = "Queen";
            this.weapon = "bow";
            this.weaponBehaviour = this;
        }

        public string UseWeapon()
        {
            return "I shoot with my " + weapon;
        }
    }
}
