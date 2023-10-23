namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat objcat = new Cat();
            objcat.Eat();
            objcat.AnimalSound();
            objcat.Habitat();

            Dog objdog = new Dog();
            objdog.Eat();
            objdog.AnimalSound();
            objdog.Habitat();
        }
    }
}