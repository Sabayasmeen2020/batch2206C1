namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle objVehicle = new Vehicle(10);
            objVehicle.start();

            Car objcar = new Car("Alto", 100);
            objcar.getSpeed();
            objcar.getModel();
            objcar.start();
            objcar.stop();

        }
    }
}