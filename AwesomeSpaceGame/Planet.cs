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
    }
}
