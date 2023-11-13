using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every Animal eats food in order to survive");
        }
        public abstract void AnimalSound(int num);
        public abstract void Habitat();

    }
}
