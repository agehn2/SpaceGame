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

        public GameManager()
        {
        }

        public void Run()
        {
            new Display().Run();

        }

    }
}
