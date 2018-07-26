using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Storage<T>
    {
        T[] _innerStore;
        int _index;

        public Storage()
        {
            _innerStore = new T[5];
            _index = 0;
        }

        public void Add(T item)
        {
            _innerStore[_index] = item;
            _index++;
        }

        public T Get(int idx)
        {
            return _innerStore[idx];
        }
    }
}
