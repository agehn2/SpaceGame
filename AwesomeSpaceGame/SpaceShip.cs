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
        double warpFactor;
        const double speedOfLight = 1.0;
        const double startMaxCapaOne = 1000;      
        



        public SpaceShip(string name)
        {
            this.name = name;
            capacity = startMaxCapaOne;
        }

        public double Speed(double warpFactor)
        {
            double speedOfSpaceShip = speedOfLight * Math.Pow(warpFactor, 3.3333 + (-0.5 * Math.Log10(10 - warpFactor)));
            if(warpFactor>=10 || warpFactor<9)
            {
                return speedOfSpaceShip = 0;
            }
            else
            {
                return speedOfSpaceShip;
            }
        }

        //void ShipSelect(int a)
        //{
        //    selectShip = a;
        //    if (select == 1)
        //    {
        //        capacity = startMaxCapaOne;
        //        speed = speedOne;
        //    }
        //    else
        //    {
        //        capacity = startMaxCapaTwo;
        //        speed = speedTwo;
        //    }
        //}

        //Add weight to ship
        public void AddCapacity(int addWeight) => capacity += addWeight;
        //Remove weight from ship player
        public void RemoveCapacity(int takeAwayWeight) => capacity -= takeAwayWeight;
            
         

       
    }
}
