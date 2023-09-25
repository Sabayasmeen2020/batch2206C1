namespace Classes_Objects2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person obj = new Person();
            

            Console.WriteLine("Person name is : "+obj.name);
            Console.WriteLine("Person age is : "+obj.age);
            obj.eating();
            obj.walking();

            Person obj1 = new Person();
            obj1.name = "Ahmed";
            obj1.age = 6;

            Console.WriteLine("Person name is : {0}\nPerson age is : {1}",obj1.name,obj1.age);
            obj1.eating();
            obj1.walking();

        }
    }
}