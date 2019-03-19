using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AwesomeSpaceGame
{
    class GameManager
    {
        Planet earth = new Planet("Earth", 0.0, 0.0);
        Planet planet1 = new Planet("Alpha Centauri 3", 25, 55); //4.37 ly
        Planet planet2 = new Planet("40 Eridani", 90.5, -150.2); //38.9 ly
        Planet planet3 = new Planet("YZ Ceti", -455.1, 900.5); //12.1
        newMarket earthMarket = new newMarket();
        newMarket alphaCentauri = new newMarket();
        newMarket Eridani = new newMarket();
        newMarket ceti = new newMarket();
        List<string> mainMenu = new List<string>(); 
        Character one = new Character();
        
        
        
        public void Run()
        {
            Display d = new Display();
            d.ASCIIMain();
            
            if (d.MainMenu())
            {
                Console.Clear();
                one.Display(); 
                one.PrintCharacter();
                one.AddMoney(100);
                one.AddAge(1.5);
                one.PrintCharacter();
                Console.ReadKey();
                one.AddAge(1.5);
                one.TakeMoney(50);
                one.PrintCharacter();
                Console.ReadKey();

                 
            }
            
            
        
        }



        public GameManager()
        {
        }

    }
}
