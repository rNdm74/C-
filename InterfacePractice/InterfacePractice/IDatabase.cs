using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePractice
{
    interface IDatabase<T>
    {
        T Query(int index);
        void Add(T t);
        void Delete(int index);
    }
}
