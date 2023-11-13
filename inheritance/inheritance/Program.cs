namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.name = "Tom";
            obj.printName();
            obj.eat();
            obj.noise();


            Animal objAnimal = new Animal();
            objAnimal.name = "tew";
            objAnimal.printName();
            objAnimal.eat();
            

        }
    }
}