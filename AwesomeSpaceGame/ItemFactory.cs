using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class ItemFactory
    {
        newMarket earthMarket = new newMarket();
        newMarket alphaCentauri = new newMarket();
        newMarket eridani = new newMarket();
        newMarket ceti = new newMarket();

        Item sE = new Item("steel", 10, 40, 3);
        Item sAC = new Item("steel", 30, 20, 3);
        Item sED = new Item("steel", 20, 30, 3);
        Item sC = new Item("steel", 40, 10, 3);

        public void AddToEarth()
        {
            earthMarket.items.Add(sE);
            earthMarket.items.Add(sAC);
            earthMarket.items.Add(sED);
            earthMarket.items.Add(sC);
        }

        public void DisplayEarthMarket()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{earthMarket.items}");
                Console.ReadKey();
            }
        }

        //Item bE = new Item("bronze", 50, 2);
        //Item bAC = new Item("bronze", 50, 2);
        //Item bEC = new Item("bronze", 50, 2);
        //Item bC = new Item("bronze", 50, 2);

        //Item gE = new Item("gold", 50, 2);
        //Item gAC = new Item("gold", 50, 2);
        //Item gED = new Item("gold", 50, 2);
        //Item gC = new Item("gold", 50, 2);

        //Item iE = new Item("iron", 50, 1);
        //Item iAC = new Item("iron", 50, 1);
        //Item iED = new Item("iron", 50, 1);
        //Item iC = new Item("iron", 50, 1);

        //Item cE = new Item("copper", 50, 3);
        //Item cAC = new Item("copper", 50, 3);
        //Item cED = new Item("copper", 50, 3);
        //Item cC = new Item("copper", 50, 3);

        //Item mE = new Item("mithril", 50, 2);
        //Item mAC = new Item("mithril", 50, 2);
        //Item mED = new Item("mithril", 50, 2);
        //Item mC = new Item("mithril", 50, 2);





    }
}
