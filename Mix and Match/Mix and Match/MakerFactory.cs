using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mix_and_Match
{
    class MakerFactory
    {
        public CharacterMaker createCharacterMaker(string characterType)
        {
            return new CharacterMaker(characterType);
        }
    }
}
