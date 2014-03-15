using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Encryptor
{
    class Rot13 : CypherMachine
    {
        public Rot13()
        {
           
        }

        public override string Encrypt(string text)
        {
            char[] charArray = text.ToCharArray();

            for (int c = 0; c < charArray.Length; c++)
            {
                int number = (int)charArray[c];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }

                charArray[c] = (char)number;
            }

            return new string(charArray);
        }
    }
}
