using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePractice
{
    class ObjectDatabase : IDatabase
    {
        public object Query(string key)
        {
            throw new NotImplementedException();
        }

        public void Add(string key)
        {
            throw new NotImplementedException();
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }
    }
}
