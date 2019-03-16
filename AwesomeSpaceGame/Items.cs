using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class Items
    {
        List<(string, int)> myList = new List<(string, int)>();
        int weight;

        public void marketOne()
        {
            myList.Add(("Item1", weight));
            myList.Add(("Item2", weight));
            myList.Add(("Item3", weight));

        }

        public void marketTwo()
        {
            myList.Add(("Item1", weight));
            myList.Add(("Item2", weight));
            myList.Add(("Item3", weight));
        }

        public void marketThree()
        {
            myList.Add(("Item1", weight));
            myList.Add(("Item2", weight));
            myList.Add(("Item3", weight));
        }

        //public void displayMarket()
        //{
        //    foreach (object o in ))
        //    {
        //        Console.WriteLine(o);
        //    }
            
       






    }
}
