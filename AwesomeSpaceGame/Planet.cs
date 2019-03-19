using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    public class Planet
    {
        public double x, y;   // TODO: Struct Coords
        public string name;
        public double distance;
        
          

        public double Distance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2 - y1), 2));  
            return distance;
        }

   

        public void StartLocation(double x, double y)
        {
            this.x = 0;
            this.y = 0;     
        }




        public Planet(string name, double x, double y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

        }

         


    }
}
