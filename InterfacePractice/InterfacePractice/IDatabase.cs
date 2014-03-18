using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePractice
{
    interface IDatabase
    {
        object Query(string key);
        void Add(string key);
        void Delete(string key);
    }
}
