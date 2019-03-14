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
        double speed;
        const double startMaxCapaOne = 1000;
        const double startMaxCapaTwo= 700;
        const double speedOne = 2;
        const double speedTwo = 5;
        int selectShip;
        int select;

        

        public SpaceShip(int a)
        {
            
            ShipSelect(a);
            
        }

        void ShipSelect(int a)
        {
            selectShip = a;
            if (select == 1)
            {
                capacity = startMaxCapaOne;
                speed = speedOne;
            }
            else
            {
                capacity = startMaxCapaTwo;
                speed = speedTwo;
            }
        }

        //Add weight to ship
        public void AddCapacity(int addWeight) => capacity += addWeight;
        //Remove weight from ship player
        public void RemoveCapacity(int takeAwayWeight) => capacity -= takeAwayWeight;
            
         

       
    }
}
