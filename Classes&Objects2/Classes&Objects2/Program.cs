namespace Classes_Objects2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person obj = new Person("Ali", 10);

            Console.WriteLine("Person name is : "+obj.name);
            Console.WriteLine("Person age is : "+obj.age);
            obj.eating();
            obj.walking();


            Person objperson = new Person(7, "Ahmed");
            Console.WriteLine(objperson.name);
            Console.WriteLine(objperson.age);
            objperson.eating();
            objperson.walking();


            Person obj2 = new Person();
            obj2.name = "Hassan";
            Console.WriteLine(obj2.name);

            Person obj3 = new Person("Huzaifa");
            obj3.eating();
        }
    }
}