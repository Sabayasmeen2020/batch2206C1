using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Student
    {
        public string name;
        public int age;
        public string qualification;

       
        public Student(string name, int age, string qualification)
        {
            this.name = name;
            this.age = age;
            this.qualification = qualification;
        }
    }
}
