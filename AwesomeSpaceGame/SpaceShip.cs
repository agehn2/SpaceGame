using System;
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
        string currentLocation ;
        public const double startMaxCapaOne = 1000;

        private const double n = 1.7952294708;
        private const double a = 0.03658749373;

        public const double warpFactor = 9.2;
        public const double warpFactor2 = 9.6;
        public const double warpFactor3 = 9.99;

        public const string spaceShipName1 = "Blue Falcon";                  //Average, $
        public const string spaceShipName2 = "M1A1 Space Edition";           //High Cap, Average, $$
        public const string spaceShipName3 = "Space Force One";              //High Cap, Fast, $$$


        public SpaceShip(string name, double capacity, double warpFactor)
        {
            this.name = name;
            capacity = GetCapacity();
            speedOfSpaceShip = Speed(warpFactor);

        }

        private double GetCapacity()
        {
            return startMaxCapaOne;//TODO: Capacity calculation
        }

        //public void startLocation()
        //{
        //    StartLocation = Planet.StartLocation();
            
        //}

        public double Speed(double warpFactor)
        {

            speedOfSpaceShip = Math.Pow(warpFactor, 10 / 3) + Math.Pow(10 - warpFactor, -11 / 3); //Math.Pow(warpFactor, (Math.Pow(((10/3) + (Math.Pow(Math.E,(-1/(1000*(Math.Pow(warpFactor-9,2))))))*a*(-Math.Log(10-warpFactor))),n))) ;  
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
            
        //AddToINV
        //RMVFROMIV
        //MAKEWEIGHTCAP
        public double Duration(Planet a,  Planet b)           //method for duration
             {
                double duration = Math.Sqrt(Math.Pow(b.x-a.x, 2) + Math.Pow(b.y-a.y, 2))/Speed(warpFactor);  
                return duration;
             }
         

       
    }
}
