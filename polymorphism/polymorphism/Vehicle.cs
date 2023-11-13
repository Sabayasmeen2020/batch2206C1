using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Vehicle
    {
        public int speed;

        public Vehicle(int speed) { 
            this.speed = speed;
        }
        public void getSpeed()
        {
            Console.WriteLine("Vehicle speed is : "+speed);
        }

        public void start()
        {
            Console.WriteLine("Vehicle is starting");
        }
        
        public void stop()
        {
            Console.WriteLine("Vehicle is stop");
        }
    }
}
