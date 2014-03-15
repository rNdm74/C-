using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Encryptor
{
    interface ICypher
    {
        string Encrypt(string text);
    }
}
