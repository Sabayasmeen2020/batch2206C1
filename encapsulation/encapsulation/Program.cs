namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee();
            obj.Name = "Ahmed";
            obj.Age = -8;
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
        }
    }
}