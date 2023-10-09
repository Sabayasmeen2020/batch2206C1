using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Car : Vehicle
    {
        public string model;

        public Car(string model, int speed) : base(speed)
        {
            this.model = model;
        }
        public void getModel()
        {
            Console.WriteLine("Car model is " + model);
        }

        public void start()
        {
            Console.WriteLine("Car is starting at speed" + speed);
        }
    }
}
