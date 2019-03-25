using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class SpaceShip
    {
        
        double capacity;
        double speedOfSpaceShip;

        private const double n = 1.7952294708;
        private const double a = 0.03658749373;

        public static double warpFactorHard = 9.0;
        public static double warpFactorMedium = 9.5;
        public static double warpFactorEasy = 9.9;

        public const double capacityHard = 90;
        public const double capacityMedium = 100;
        public const double capacityEasy = 110;

        public (string nameSpaceShip, double capacitySpaceShip, double warpFactorHard) spaceShipHard
                                                        = ("Blue Falcon", capacityHard, 9.5);

        public (string nameSpaceShip, double capacitySpaceShip, double warpFactorMedium) spaceShipMedium
                                                        = ("Blue Falcon", capacityMedium, 9.6);

        public (string nameSpaceShip, double capacitySpaceShip, double warpFactorEasy) spaceShipEasy
                                                        = ("Blue Falcon", capacityEasy, 9.7);


        public SpaceShip()
        {
        }

        public SpaceShip(string name, double capacity, double warpFactor)
        {
         
        }

        public (string, double, double) SelectSpaceShip(ConsoleKey key)
        { 
            if (key==ConsoleKey.H)
            {
                return spaceShipHard;
            }
            else if (key == ConsoleKey.M)
            {
                return spaceShipMedium;
            }
            else if (key == ConsoleKey.E)
            {
                return spaceShipEasy;
            }

            return ("",0,0);
        }

        public double Speed(double warpFactor)
        {
            //TODO: Customize
            speedOfSpaceShip = Math.Pow(warpFactor, 10 / 3) + Math.Pow(10 - warpFactor, -11 / 3); //Math.Pow(warpFactor, (Math.Pow(((10/3) + (Math.Pow(Math.E,(-1/(1000*(Math.Pow(warpFactor-9,2))))))*a*(-Math.Log(10-warpFactor))),n))) ;  
            if (warpFactor >= 10 || warpFactor < 9)
            {
                return speedOfSpaceShip = 0;
            }
            else
            {
                return speedOfSpaceShip;
            }
        }
        public double SelectWarpFactor(int i)
        {
            if (i == 0)
                return warpFactorEasy;
            else if (i == 1)
                return warpFactorMedium;
            else
                return warpFactorHard;
        }

        //Add weight to ship
        public void AddItem(int addItem) => capacity += addItem;

        //Remove weight from ship player
        public void RemoveCapacity(int takeAwayWeight) => capacity -= takeAwayWeight;

        //AddToINV
        //RMVFROMIV
        //MAKEWEIGHTCAP
        
        public double Duration(Planet a, Planet b, double warpFactor)           //method for duration
        {
            double duration = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2)) / warpFactor;
            return duration;
        }

       
    }
}     
    

