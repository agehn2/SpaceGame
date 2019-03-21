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
        Item sE = new Item("steel:  ", 20, 35, 40, 3);
        //Item sAC = new Item("steel: ", 30, 20, 3);
        //Item sED = new Item("steel: ", 20, 30, 3);
        //Item sC = new Item("steel: ", 40, 10, 3);

        Item bE = new Item("bronze: ", 50, 60, 30, 2);
        //Item bAC = new Item("bronze: ", 50, 20, 2);
        //Item bED = new Item("bronze: ", 50, 30, 2);
        //Item bC = new Item("bronze: ", 50, 20, 2);

        Item gE = new Item("gold:   ", 50, 80, 20, 2);
        //Item gAC = new Item("gold:  ", 50, 20, 2);
        //Item gED = new Item("gold:  ", 50, 20, 2);
        //Item gC = new Item("gold:  ", 50, 10, 2);

        Item iE = new Item("iron:   ", 50, 70, 20, 1);
        //Item iAC = new Item("iron:   ", 50, 30, 1);
        //Item iED = new Item("iron:   ", 50, 30, 1);
        //Item iC = new Item("iron:   ", 50, 20, 1);

        Item cE = new Item("copper: ", 50, 70, 80, 3);
        //Item cAC = new Item("copper: ", 50, 20, 3);
        //Item cED = new Item("copper: ", 50, 30, 3);
        //Item cC = new Item("copper: ", 50, 20, 3);

        Item mE = new Item("mithril:", 50, 70, 30, 2);
        //Item mAC = new Item("mithril:", 50, 30, 2);
        //Item mED = new Item("mithril:", 50, 20, 2);
        //Item mC = new Item("mithril:", 50, 10, 2);

        private void AddToEarth()
        {
            earthMarket.items.Add(sE);
            earthMarket.items.Add(bE);
            earthMarket.items.Add(gE);
            earthMarket.items.Add(iE);
            earthMarket.items.Add(mE);
        }

        //private void AddToAlphaCentauri()
        //{
        //    alphaCentauri.items.Add(sAC);
        //    alphaCentauri.items.Add(bAC);
        //    alphaCentauri.items.Add(gAC);
        //    alphaCentauri.items.Add(iAC);
        //    alphaCentauri.items.Add(mAC);
        //}

        //private void AddToEridani()
        //{
        //    eridani.items.Add(sED);
        //    eridani.items.Add(bED);
        //    eridani.items.Add(gED);
        //    eridani.items.Add(iED);
        //    eridani.items.Add(mED);
        //}

        //private void AddToCeti()
        //{
        //    ceti.items.Add(sC);
        //    ceti.items.Add(bC);
        //    ceti.items.Add(gC);
        //    ceti.items.Add(iC);
        //    ceti.items.Add(mC);
        //}

        

        public void DisplayEarthMarket()
        {
            

            AddToEarth();
            //Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\nItem Name\t\t     Price of Item\t\t      Sell Price\t\t       Weight");           
            Console.WriteLine("========================================================================================================================");
            for (int i = 0; i < (earthMarket.items.Count); i++)
            {
                Console.WriteLine($"{earthMarket.items[i].itemName}\t --\t\t  {earthMarket.items[i].cost}\t\t --\t\t  {earthMarket.items[i].price}\t\t --\t\t  {earthMarket.items[i].weight}\n");
            }           
            Console.WriteLine("\n\nMake A Selection:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=================");
            Console.ResetColor();
            Console.WriteLine(" B. Buy Item\n S. Sell Item\n V. View Inventory\n M. Exit Shop");
            Console.ReadKey();
        }

        // public void DisplayAlphaCentauriMarket()
        //{
        //    Console.Clear();
        //    AddToAlphaCentauri();
        //    Console.WriteLine("");
        //    for (int i = 0; i < (alphaCentauri.items.Count); i++)
        //    {
        //        Console.WriteLine($"{alphaCentauri.items[i].itemName} --  {alphaCentauri.items[i].price}");
        //    }
        //        Console.ReadKey();
        //}

        // public void DisplayEridaniMarket()
        //{
        //    Console.Clear();
        //    AddToEridani();
        //    Console.WriteLine("");
        //    for (int i = 0; i < (eridani.items.Count); i++)
        //    {
        //        Console.WriteLine($"{eridani.items[i].itemName} --  {eridani.items[i].price}");
        //    }
        //        Console.ReadKey();
        //}

        // public void DisplayCetiMarket()
        //{
        //    Console.Clear();
        //    AddToCeti();
        //    Console.WriteLine("");
        //    for (int i = 0; i < (ceti.items.Count); i++)
        //    {
        //        Console.WriteLine($"{ceti.items[i].itemName} --  {ceti.items[i].price}");
        //    }
        //        Console.ReadKey();
        //}

     




    }
}
