namespace classes_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person();
            obj1.name = "Ahmed";
            obj1.age = 25;

            obj1.greet();


            Person obj2 = new Person();
            obj2.name = "Usman";
            obj2.age = 15;

            obj2.greet();
        }
    }
}