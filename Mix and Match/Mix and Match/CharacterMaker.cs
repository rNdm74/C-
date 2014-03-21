using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Mix_and_Match
{
    class CharacterMaker
    {
        protected string characterLabel;
        
        public CharacterMaker(string characterLabel)
        {
            this.characterLabel = characterLabel;
        }

        public Bitmap HeadImage()
        {
            return new Bitmap("images/" + characterLabel + "_0.png");
        }

        public Bitmap BodyImage()
        {
            return new Bitmap("images/" + characterLabel + "_1.png");
        }

        public Bitmap LegsImage()
        {
            return new Bitmap("images/" + characterLabel + "_2.png");
        }
    }
}
