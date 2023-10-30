namespace delegates
{

    internal class Program
    {
        public delegate int Calculation(int num1, int num2);

        static int Addtion(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            Mathematics objmaths = new Mathematics();
            objmaths.addlist();
            objmaths.getlist();
            objmaths.setlist();
            objmaths.setnewlist();
            //Calculation objCal = new Calculation(Addtion);
            //Console.WriteLine(objCal(3, 4));
            //Calculation objCal1 = new Calculation(Subtraction);
            //Console.WriteLine(objCal1(4,7));
        }
    }
}