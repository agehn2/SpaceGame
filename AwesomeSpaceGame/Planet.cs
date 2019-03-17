using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class Planet
    {
        double x, y;
        string name;
        double distance;
        
        //Planet earth = new Planet("Earth", 0.0, 0.0);
        //Planet planet1 = new Planet("Alpha Centauri 3", 2.3, 3.7); //4.37 ly
        //Planet planet2 = new Planet("40 Eridani", 16.6,-35.2); //38.9 ly
        //Planet planet3 = new Planet("YZ Ceti",-6.1,10.5); //12.1

        //public double Run()
        //{
        //    Distance(planet1.x, planet1.y, planet2.x, planet2.y);
        //    return distance;
        //}

        public double Distance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2 - y1), 2));  
            return distance;
        }

        private double Duration(double distance, double warpFactor)
        {
            return 0;
        }

        public void AddMarket()
        {
            
        }




        public Planet(string name, double x, double y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

        }

        public Planet()
        {

        }


    }
}
