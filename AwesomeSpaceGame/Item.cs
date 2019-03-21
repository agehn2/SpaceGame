using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class Item
    {
        public string itemName;
        public int cost;
        public double weight;
        public double price;
        
       

        public Item(string nameOfItem, int a, int b , double sellPrice, double weightOfItem)
        {
            itemName = nameOfItem;
            cost = newMarket.RandomNumber(a, b);           //.RandomNumber(a,a);
            price = sellPrice;
            weight = weightOfItem;
        }

           
        

        //public void AddItem(Item thing)
        //{
        //    items.Add(thing);
        //}







    }
}
//Earth - Your home planet.While earth is known for it production of steel, they are very in need of bronze and gold.

//Alpha Centauri - This planet is the closest of the planets to earth, and they work very well together in relaying materials
//that the other planet is short on.But they are very plentiful in iron, and copper, but share a similarity of earth for being in need of gold.

//Eridani- This planet is very plentiful in Copper and iron, but they are having trouble keeping up with there need of steel, and mithril.

//YZ Ceti- This planet is known for its consumption of bronze, but are in need of steel. 

