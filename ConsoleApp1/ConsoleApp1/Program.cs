﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1;
            //double num2 = 7;

            //num1 = (int)num2;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //Console.Write("Enter a Number: ");
            //int num = Convert.ToInt32(Console.ReadLine());  // accepts both positive and negative number
            //uint num1 = 4; // accepts only positive number

            //if (num < 0)
            //{
            //    Console.WriteLine("Number is negative");
            //}
            //else
            //{
            //    Console.WriteLine("Number is positive");
            //}


            //Console.Write("Enter a number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if(num2 % 2 == 0) 
            //{
            //    Console.WriteLine("Number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}



            //Console.Write("Enter your salary : ");
            //int salary = Convert.ToInt32(Console.ReadLine());
            //if( salary > 50000)
            //{
            //    Console.WriteLine("Your salary is : "+salary);
            //    Console.WriteLine("Calculated bonus: "+ (salary * 0.2));
            //}
            //else
            //{
            //    Console.WriteLine("Your salary is : " + salary);
            //    Console.WriteLine("Calculated bonus: " + (salary * 0.5));
            //}



            //nested ifs

            //int yrsofServices = 3;
            //double salary = 400;
            //int bonus = 0;

            //if(yrsofServices < 5)
            //{
            //    if(salary < 500)
            //    {
            //        bonus = 100;
            //    }
            //    else
            //    {
            //        bonus = 500;
            //    }
            //}
            //else
            //{
            //    bonus = 700;
            //}

            //Console.WriteLine(bonus);


            //string username = Console.ReadLine();

            //if(username == "Admin") {
            //    Console.WriteLine("username is correct");
            //}
            //else if(username == "Admin@gmail.com")
            //{
            //    Console.WriteLine("username is correct");
            //}
            //else
            //{
            //    Console.WriteLine("username is incorrect");
            //}


            //int num = Convert.ToInt32(Console.ReadLine());

            //switch(num)
            //{
            //    case 1 :
            //        Console.WriteLine("This is case 1");
            //        break;
            //    case 2 :
            //        Console.WriteLine("This is case 2");
            //        break;
            //    case 3 :
            //        Console.WriteLine("This is case 3");
            //        break;
            //    case 4 :
            //        Console.WriteLine("This is case 4");
            //        break;
            //    default:
            //        Console.WriteLine("Default case");
            //        break;
            //}

            //Console.Write("Enter character (+, - , * , / ) : ");
            //char operators = Convert.ToChar(Console.ReadLine());
            //Console.Write("Enter a number : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //switch (operators)
            //{
            //    case '+':
            //        Console.WriteLine($"Additon of {num1} and {num2} is ({num1 + num2})");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Subtraction of {num1} and {num2} is ({num1 - num2})");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Multiplication of {num1} and {num2} is ({num1 * num2})");
            //        break;
            //    case '/':
            //        Console.WriteLine($"Division of {num1} and {num2} is ({num1 / num2})");
            //        break;
            //    default:
            //        Console.WriteLine("Default case");
            //        break;
            //}



            //Loops 

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World\n");
            //}


            //int i = 0;
            //while (i != 0)
            //{
            //    Console.WriteLine(i);
            //    //i++;
            //    i = Convert.ToInt32(Console.ReadLine());
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Enter a number (1-4): ");
            //    i = Convert.ToInt32(Console.ReadLine());    
            //}while (i < 1 || i > 4);

            //nested loop

            //for(int i = 0; i < 5; i++)  //outer loop
            //{
            //    for(int j = 0; j < 5; j++)   //inner loop
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}


            //Arrays  

            string[] students = new string[] { "Ahmed", "Usman", "Ali", "Huzaifa" };
            //Console.WriteLine(students[0]);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }


            int[][] number = new int[3][];
            number[0] = new int[3] { 1, 2, 3 };
            number[1] = new int[3] { 1, 2, 3 };
            number[2] = new int[3] { 1, 2, 3 };
           

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number[i].GetLength(0) ; j++)
                {
                    Console.WriteLine(number[i][j]);
                }
            }


            string[][] companies = new string[3][];
            companies[0] = new string[] {"Abc" ,"Xyz" };
            companies[1] = new string[] {"Abc" ,"Xyz" ,"qwe" };
            companies[2] = new string[] {"Abc" ,"Xyz", "uyt", "bvn"};

            for(int i = 0; i < companies.Length; i++)
            {
                for(int j= 0; j < companies[i].Length; j++)
                {
                    Console.WriteLine(companies[i][j]);
                }
            }


        }
    }
}