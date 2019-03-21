﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    public class Planet
    {
        static List<string> planetName = new List <string>();

        public double x, y;   // TODO: Struct Coords
        public string name;
        public double distance;

        public double Distance(Planet a, Planet b)
        {
            double distance = Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
            return distance;
        }

        public Planet(string name, double x, double y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

        }

        public static bool PlanetDescription()
        {
            Console.WriteLine("Earth - Your home planet. While earth is known for it production of steel , they are very in need of bronze and gold.");
            Console.WriteLine("Alpha Centauri - This planet is the closest of the planets to earth, and they work very well together in relaying materials that the other planet is short on. But they are very plentiful in iron, and copper, but share a similarity of earth for being in need of gold.");
            Console.WriteLine("Eridani- This planet is very plentiful in Copper and iron, but they are having trouble keeping up with there need of steel, and mithril.");
            Console.WriteLine("YZ Ceti- This planet is known for its consumption of bronze, but are in need of steel.");
            Console.ReadKey();
            return false;
        }       
        
        private double duration (Planet a, Planet b, double speedOfSpaceShip)
        {
            double duration = distance / speedOfSpaceShip;
            return duration;
        }

        
    }
}
