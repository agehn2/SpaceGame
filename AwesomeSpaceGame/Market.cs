using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class newMarket
    {
        List<Item> items = new List<Item>();

        public void AddItem(Item thing)
        {
            items.Add(thing);
        }

    }
}
//string itemName;
//double cost;
//double weight;

//public void createItem(string nameOfItem, double costOfItem, double weightOfItem)
//{
//    itemName = nameOfItem;
//    cost = costOfItem;
//    weight = weightOfItem;
//}


//items.add(new item("name", 2.00, 5.00))
//List<Planet> planets = new List<Planet>();
//planets.Add(new Planet("Earth", 0.0, 0.0));
//Market earthMarket = new Market();
//earthMarket.AddItem(new Item("name", 2.00, 5.00));
//AddItem