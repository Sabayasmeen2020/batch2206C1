using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Dog : Animal
    {
        public override void AnimalSound(int n)
        {
            Console.WriteLine("Dog sound is Woff");
        }

        public override void Habitat()
        {
            Console.WriteLine("Cat is Carnivorous and domestic animal");
        }
    }
}
