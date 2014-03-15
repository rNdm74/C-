using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_Encryptor
{
    abstract class CypherMachine: ICypher
    {
        protected ICypher cypher;

        public CypherMachine()
        {
            cypher = this;
        }

        public abstract string Encrypt(string text);
    }
}
