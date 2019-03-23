using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    public class Item
    {
        public string itemName;
        public int askPrice;
        public int offerPrice;
        public int weight;

        public Item(string nameOfItem, int a, int b , int c, int d, int weight)
        {
            itemName = nameOfItem;
            askPrice = RandomNumber(a, b);           //.RandomNumber(a,a);
            offerPrice = RandomNumber(c, d);
            this.weight = weight;
        }
       
         public static int RandomNumber(int min, int max)  
        {  
            Random random = new Random();  
            return random.Next(min, max);  
        } 

           
        

        public void AddItem(Item thing)
        {
            //items.Add(thing);
        }







    }
}
