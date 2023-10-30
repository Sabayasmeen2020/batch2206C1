using System.Collections;
using System.Collections.Generic;


namespace Collections
{
    class General<T>
    {
        public T value;

        public General(T value) {
            this.value = value;
        }

        public void getValue()
        {
            Console.WriteLine("The value is "+value);
        }
    }

    enum Months
    {
        January,
        February,
        March,
        April,
        May 
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //enumumeration 

            Console.WriteLine(Months.May);

            // Tuple

            var record = Tuple.Create(1, "Sana", 29);
            Console.WriteLine(record.Item1);
            Console.WriteLine(record.Item2);
            Console.WriteLine(record.Item3);

            //Dictionary<int, Student> objStu = new Dictionary<int, Student>();
            //objStu.Add(1001, new Student("Ali", 2, "Graduation"));
            //objStu.Add(1002, new Student("Aliyan", 22, "Graduation"));
            //objStu.Add(1003, new Student("Ahmed", 12, "Graduation"));

            //foreach(var i in objStu)
            //{
            //    Console.WriteLine(i.Key + " " + i.Value.name + " " + i.Value.age + " " + i.Value.qualification);
            //}

            //Console.Write("Enter key to remove element: ");
            //int key = Convert.ToInt32(Console.ReadLine());

            //if(key > 0)
            //{
            //    objStu.Remove(key);
            //    foreach (var i in objStu)
            //    {
            //        Console.WriteLine(i.Key + " " + i.Value.name + " " + i.Value.age + " " + i.Value.qualification);
            //    }
            //}



            //General<int> g = new General<int>(23);
            //General<string> g1 = new General<string>("Ali");
            //g.getValue();
            //g1.getValue();


            //Dictionary<string, string> objDictionary = new Dictionary<string, string> ();
            //objDictionary.Add("A", "Hardisk");
            //objDictionary.Add("B", "Processor");
            //objDictionary.Add("C", "Motherboard");

            //foreach(var i in objDictionary)
            //{
            //    Console.WriteLine(i.Key +  " " + i.Value);
            //}

            //objDictionary.Remove("A");
            //Console.WriteLine("After eliminate key 2");
            //foreach (var i in objDictionary)
            //{
            //    Console.WriteLine(i.Key + " " + i.Value);
            //}

            //objDictionary.Clear();
        }
    }
}