using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Cat : Animal
    {
        public override void AnimalSound(int n)
        {
            Console.WriteLine("Cat sound is Meow Meow");
        }

        public override void Habitat()
        {
            Console.WriteLine("Cat is Carnivorous and lives in open forest");
        }
    }
}
