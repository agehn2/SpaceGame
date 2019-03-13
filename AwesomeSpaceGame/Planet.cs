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
            enterDestination();
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

        private double calculateDistance()
        {
            
        }
    }
}
