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

        public SpaceShip()
        {
            capacity = 1000;
        }
        public void AddCapacity(int addWeight)
        {
            capacity += addWeight;
        }
        //Take money from player
        public void RemoveCapacity(int takeAwayWeight)
        {
            capacity -= takeAwayWeight;
        }
    }
}
