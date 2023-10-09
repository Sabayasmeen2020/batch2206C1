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

        public Person(string name)
        {
            this.name = name;
        }
        public Person(int age)
        {
            this.age = age;
        }
        public Person(string name, int age)  // PARAMETRIZED CONSTRUCTOR 
        {
            this.name = name;
            this.age = age;
        }

        //constructor overloading

        public Person(int age, string name)  // PARAMETRIZED CONSTRUCTOR 
        {
            this.name = name;
            this.age = age;
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
