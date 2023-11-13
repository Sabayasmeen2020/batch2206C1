using ns = electronics.mobile;

namespace Namespaces_exeptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numone = 20;
            int numtwo = 0;

            int result;
            try
            {
                result = numone / numtwo;
            }
            catch (Exception ex)
            {
                result = 0;
                Console.WriteLine("Divisor can not be zero "+ ex.Message);
            }
            Console.WriteLine(result);

            //mobile objmobile = new mobile();
            //objmobile.walkman();
            //ns.samsung mobile = new ns.samsung();
            //mobile.greeting();
        }
    }
    class mobile
    {
        public void walkman()
        {
            Console.WriteLine("Within the namespace");
        }
    }

}

namespace electronics
{
    namespace mobile
    {
        class samsung
        {
            public void greeting()
            {
                Console.WriteLine("calling from another namespace");
            }
        }
    }
   
}
