using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class ItemFactory
    {
        Market earthMarket = new Market();
        Market alphaCentauriMarket = new Market();
        Market eridaniMarket = new Market();
        Market cetiMarket = new Market();
        Market newPlanetMarket = new Market();
        
        //Earths Market
        Item sE = new Item("steel:  ", 75, 80, 65,70, 2);
        Item bE = new Item("bronze: ", 335, 395, 320,335, 4);
        Item iE = new Item("iron:   ", 345, 395, 335, 345, 5);
        Item gE = new Item("gold:   ", 205, 245, 160, 175, 3);
        Item cE = new Item("copper: ", 410, 480, 400, 410, 4);
        Item mE = new Item("mithril:", 550, 850, 400, 450, 8);
        
        //AC  Market
        Item sAC = new Item("steel: ", 100, 110, 90, 100, 2);
        Item bAC = new Item("bronze: ", 255, 290, 240, 255, 4);
        Item iAC = new Item("iron:   ", 265, 305, 245, 255, 5);
        Item gAC = new Item("gold:  ", 175, 200, 140, 150, 3);
        Item cAC = new Item("copper: ", 375, 415, 360, 375, 4);

        //Eridani Buy Market
        Item sED = new Item("steel: ", 120, 130, 105, 120, 2);
        Item bED = new Item("bronze: ", 210, 255, 195, 210, 4);
        Item iED = new Item("iron:   ", 215, 250, 200, 215, 5);
        Item gED = new Item("gold:  ", 255, 295, 240, 255, 3);
        Item cED = new Item("copper: ", 270, 305, 255, 265, 4);
       
        //ceti Buy Market
        Item sC = new Item("steel: ", 250, 265, 235, 250, 2);
        Item bC = new Item("bronze: ", 410, 465, 390, 405, 4);
        Item iC = new Item("iron:   ", 420, 500, 410, 420, 5);
        Item gC = new Item("gold:  ", 315, 360, 300, 315, 3);
        Item cC = new Item("copper: ", 320, 370, 300, 310, 4);
        Item mC = new Item("mithril", 200, 300, 180, 200, 8);

        private void AddToNewPlanet()
        { 
            
        }

        private void AddToEarth()
        {
            earthMarket.items.Add(sE);
            earthMarket.items.Add(bE);
            earthMarket.items.Add(gE);
            earthMarket.items.Add(iE);
            earthMarket.items.Add(cE);
        }

        private void AddToAlphaCentauri()
        {
            alphaCentauriMarket.items.Add(sAC);
            alphaCentauriMarket.items.Add(bAC);
            alphaCentauriMarket.items.Add(gAC);
            alphaCentauriMarket.items.Add(iAC);
            alphaCentauriMarket.items.Add(cAC);
        }

        private void AddToEridani()
        {
            eridaniMarket.items.Add(sED);
            eridaniMarket.items.Add(bED);
            eridaniMarket.items.Add(gED);
            eridaniMarket.items.Add(iED);
            eridaniMarket.items.Add(cED);
        }

        private void AddToCeti()
        {
            cetiMarket.items.Add(sC);
            cetiMarket.items.Add(bC);
            cetiMarket.items.Add(iC);
            cetiMarket.items.Add(gC);
            cetiMarket.items.Add(cC);
            cetiMarket.items.Add(mC);
        }

        

        public void DisplayEarthMarket()
        {
            AddToEarth();
            //Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\nItem Name\t\t     Price of Item\t\t      Sell Price\t\t       Units");
            Console.WriteLine("========================================================================================================================");
            for (int i = 0; i < (earthMarket.items.Count); i++)
            {
                Console.WriteLine($"{earthMarket.items[i].itemName}\t --\t\t  {earthMarket.items[i].askPrice}\t\t --\t\t  {earthMarket.items[i].offerPrice}\t\t --\t\t  {earthMarket.items[i].units}\n");
            }
            Console.WriteLine("\n\nMake A Selection:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=================");
            Console.ResetColor();
            Console.WriteLine(" B. Buy Item\n S. Sell Item\n V. View Inventory\n M. Exit Shop");
            Console.ReadKey();
        }

        public void DisplayCurrentMarket(Market a)
        {
            
            //Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\nItem Name\t\t     Price of Item\t\t      Sell Price\t\t       Units");
            Console.WriteLine("========================================================================================================================");
            for (int i = 0; i < (a.items.Count); i++)
            {
                Console.WriteLine($"{a.items[i].itemName}\t --\t\t  {a.items[i].askPrice}\t\t --\t\t  {a.items[i].offerPrice}\t\t --\t\t  {a.items[i].units}\n");
            }
            Console.WriteLine("\n\nMake A Selection:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=================");
            Console.ResetColor();
            Console.WriteLine(" B. Buy Item\n S. Sell Item\n V. View Inventory\n M. Exit Shop");
            Console.ReadKey();
        }

         public Market CurrentMarket(Planet e, Planet a, Planet b, Planet c, Planet d)
         {
            if (e == a)
            {
                Console.WriteLine("earths market");
                AddToEarth();
                return earthMarket;
            }
            else if (e == b)
            {
                Console.WriteLine("Alpha Centauri Market");
                AddToAlphaCentauri();
                return alphaCentauriMarket;
            }
            else if (e == c)
            {
                Console.WriteLine("Eridani Market");
                AddToEridani();
                return eridaniMarket;
            }
            else if (e == d)
            {
                Console.WriteLine("Ceti Market");
                AddToCeti();
                return cetiMarket;
            }
            else
            {
                Console.WriteLine("New planet Market");
                AddToNewPlanet();    
                return newPlanetMarket;
            }
             
         }

    }
}








