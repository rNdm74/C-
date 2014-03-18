using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePractice
{
    class ObjectDatabase<T> : IDatabase<T>
    {
        List<T> t;

        public ObjectDatabase()
        {
            this.t = new List<T>();
        }

        public int Count()
        {
            return t.Count;
        }

        public T Query(int index)
        {   
            return this.t[index];
        }

        public void Add(T t)
        {
            this.t.Add(t);
        }

        public void Delete(int index)
        {
            this.t.RemoveAt(index);
        }        
    }
}
