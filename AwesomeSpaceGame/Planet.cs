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
        Planet earth = new Planet("Earth", 0.0, 0.0);
        Planet planet1 = new Planet("Alpha Centauri 3", 2.3, 3.7); //4.37 ly
        Planet planet2 = new Planet("40 Eridani", 16.6,-35.2); //38.9 ly
        Planet planet3 = new Planet("YZ Ceti",-6.1,10.5); //12.1

        private double Distance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

        private double Duration(double distance, double warpFactor)
        {
            double duration = distance / SpaceShip.

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

        public void Run()
        {
            getDistance();
        }

        private void getDistance()
        {
            string earthName = "Earth";
            double earthX = 0.0;
            double earthY = 0.0;

            string alphaCentName = "Alpha Centauri 3";
            double alphaX = -2.3;
            double alphaY = 3.4;

            Planet planetEarth = new Planet(earthName, earthX, earthY);
            Planet planetAlpha = new Planet(alphaCentName, alphaX, alphaY);

            double distance = calculateDistance();


        }

    }
}
