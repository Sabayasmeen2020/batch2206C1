using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects2
{
    internal class Person
    {
        public string name;
        public int age;

        public Person() //user defined constructor , no parameter contructor
        {
            this.name = "Guest User";
            this.age = 0;
        }

        public void eating()
        {
            Console.WriteLine(name + " is eating");
        }

        public void walking()
        {
            Console.WriteLine("{0} is walking",name);
        }
    }
}
