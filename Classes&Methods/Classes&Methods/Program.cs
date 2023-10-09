namespace Classes_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product(1101, "Tooth brush", 54f);
            //objProduct.productDisplay();
            //Console.WriteLine(objProduct.getDiscount(5));
            //double discount =  objProduct.getFlatDiscount();
            //Console.WriteLine("Flat Discount : " + discount);

            Console.WriteLine(objProduct.add(3, 5));
            Console.WriteLine(objProduct.add(3.2f));
            Console.WriteLine(objProduct.add(2));
            Console.WriteLine(objProduct.add(2.2,4));
            Console.WriteLine(objProduct.add(2,4.2));
        }
    }
}