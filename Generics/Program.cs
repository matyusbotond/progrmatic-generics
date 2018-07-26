using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Storage<Person>();

            //store.Add("asd");
            //store.Add(5);
            store.Add(new Person("Béla"));

            //object item = store.Get(2);
            Person item = store.Get(2);

            var stringStore = new Storage<string>();

            var list = new List<Person>();
        }
    }
}
