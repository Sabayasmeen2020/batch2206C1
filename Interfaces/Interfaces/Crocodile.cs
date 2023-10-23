using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Crocodile : ITerrestrialAnimal, IMarineAnimal
    {
        public void eat()
        {
            Console.WriteLine("The crocodile eat flesh");
        }

        public void swim(int a) 
        {
            Console.WriteLine("The crocodile can swim four times faster than olympic swimmers");
        }

        public void sleep()
        {
            Console.WriteLine("According to me crocodile sleeps alot");
        }
        public void demo()
        {
            Console.WriteLine("Demo method");
        }
    }
}
