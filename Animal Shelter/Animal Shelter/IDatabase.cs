using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Shelter
{
    interface IDatabase<T>
    {
        int Count();
        void Add(T t);
        void Delete(T t);
        void Modify(int i, T t);
        List<T> Search(string s);        
    }
}
