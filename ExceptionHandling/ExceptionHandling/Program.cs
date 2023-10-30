 namespace ExceptionHandling
{
    internal class Program
    {
        static void Evaluate(string input1)
        {
            if(input1 == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
            Console.WriteLine("Value is: "+input1);

            }
        }
        static void Main(string[] args)
        {
            Evaluate("Usman");
            try
            {
                Evaluate(null);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string[] _names = {"Ali", "Ahmed", "Usman"};
            try
            {
                Console.WriteLine(_names[2]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally block is executed");
            }

            int numone = 13;
            int numtwo = 0;
            double result;
            try
            {
                result = numone / numtwo;
                Console.WriteLine("Answer :" + result);
            }
            catch(DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }


        }
    }
}