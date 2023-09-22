using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_objects
{
    internal class Person
    {
        public string name;
        public int age;


        public void greet()
        {
            Console.WriteLine("Hello "+name);
            Console.WriteLine(name + " your age is "+age);
        }
    }
}
