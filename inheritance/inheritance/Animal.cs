using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Animal
    {
        public string name;

        public void eat()
        {
            Console.WriteLine("Animal eats");
        }

        public void printName()
        {
            Console.WriteLine("Its name is "+ name);
        }
    }
}
