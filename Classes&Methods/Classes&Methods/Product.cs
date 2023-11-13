using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods
{
    internal class Product
    {
        int product_id;
        string product_name;
        float product_price;

        public Product(int product_id, string product_name, float product_price)
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.product_price = product_price;
        }

        public void productDisplay()
        {
            Console.WriteLine("Product ID : "+ product_id);
            Console.WriteLine("Product Name : "+ product_name);
            Console.WriteLine("Product Price : "+ product_price);
        }

        public double getDiscount(int percent)
        {
            //Console.WriteLine("After Discount " + (product_price - product_price * percent / 100));
            return product_price - product_price * percent / 100;
        }


        //number of parameter
        //Type of parameter
        //Arrangement of parameter    within the class

        public double getFlatDiscount()
        {
            int percent = 10;
            return product_price - product_price * percent / 100;
        }
        
        public int add(int num)
        {
            return 2 + 2;
        }

        public float add(float num)
        {
            return num + num;
        }

        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double add(double num1 , int num2)
        {
            return num1 + num2;
        }


        public double add(int num1, double num2)
        {
            return num1 + num2;
        }
    }
}
