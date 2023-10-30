using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Mathematics
    {
        ArrayList objarr = new ArrayList();
        List<int> objlist = new List<int>(); 
        SortedList<int, string> objsorted = new SortedList<int, string>();  
        SortedList<string, string> objsorted1 = new SortedList<string, string>();
        public void addlist()
        {
            objarr.Add(1);
            objarr.Add("Ali");
            objarr.Add(3);
            objarr.Add(4.5);
            objarr.Add("Ahmed");
            objarr.Add(6);
        }

        public void getlist()
        {
            foreach(var i in objarr)
            {
                Console.WriteLine(i);
            }
        }

        // for List generic
        public void lst()
        {
            objlist.Add(3);
            objlist.Add(6);
            objlist.Add(8);
            objlist.Add(2);
        }

        //for sortedlist

        public void setlist()
        {
            objsorted.Add(8, "Ali");
            objsorted.Add(2, "ahmed");
            objsorted.Add(1, "amna");
            objsorted.Add(7, "Alyan");
            objsorted.Add(4, "summan");
            objsorted.Add(3, "sami");

            foreach(var i in objsorted)
            {
                Console.WriteLine(i.Key+ " " + i.Value);
            }
        }

        public void setnewlist()
        {
            objsorted1.Add("sana", "masters");
            objsorted1.Add("bisma", "intermediate");
            objsorted1.Add("Mahnoor", "graduation");

            foreach (var i in objsorted1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }
        
    }
}
