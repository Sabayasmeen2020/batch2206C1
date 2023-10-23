using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class employee
    {
        private string _name;
        private int _age;

        public string Name
        {
            set { _name = value; }
            get { return _name; }   
        }

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                }
            }
            get { return _age; }
        }
    }
}
