using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mix_and_Match
{
    interface Factory
    {
        CharacterMaker createCharacterMaker(string characterType);
    }

    class MakerFactory : Factory
    {
        public CharacterMaker createCharacterMaker(string characterType)
        {
            return new CharacterMaker(characterType);
        }
    }
}
