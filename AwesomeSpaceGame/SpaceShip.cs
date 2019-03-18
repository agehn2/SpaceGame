﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class SpaceShip
    {
        string name;
        double capacity;
        double speedOfSpaceShip;
        const double speedOfLight = 1.0;
        public const double startMaxCapaOne = 1000;

        private const double n = 1.7952294708;
        private const double a = 0.03658749373;

        public const double warpFactor = 9.5;
        public const double warpFactor2 = 9.9;
        public const double warpFactor3 = 9.99;

        public const string spaceShipName1 = "Blue Falcon";                  //Average, $
        public const string spaceShipName2 = "M1A1 Space Edition";           //High Cap, Average, $$
        public const string spaceShipName3 = "Space Force One";              //High Cap, Fast, $$$


        public SpaceShip(string name, double capacity, double warpFactor)
        {
            this.name = name;
            capacity = getCapacity();
            speedOfSpaceShip = Speed(warpFactor);

        }

        private double getCapacity()
        {
            return startMaxCapaOne;//TODO: Capacity calculation
        }

        public double Speed(double warpFactor)
        {
            speedOfSpaceShip = Math.Pow(warpFactor, (10/3))+Math.Pow((10-warpFactor),-11/3);  //Warp Factor: -0.5 * Math.Log10(10-F)
            if(warpFactor>=10 || warpFactor<9)
            {
                return speedOfSpaceShip = 0;
            }
            else
            {
                return speedOfSpaceShip;
            }
        }

     
        //Add weight to ship
        public void AddCapacity(int addWeight) => capacity += addWeight;
        //Remove weight from ship player
        public void RemoveCapacity(int takeAwayWeight) => capacity -= takeAwayWeight;
            
         

       
    }
}
