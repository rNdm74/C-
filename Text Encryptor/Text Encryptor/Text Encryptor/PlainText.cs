using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Encryptor
{
    class PlainText : CypherMachine
    {
        public PlainText()
        {
            
        }

        public override string Encrypt(string text)
        {
            return text;
        }
    }
}
