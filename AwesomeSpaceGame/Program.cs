using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    public class Program
    {

        
        static void Main(string[] args)
        {       
        
            new Display().Run();
            Console.Clear();
            Character one = new Character();
            Console.Write("What is your Name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"{one.Intro(userInput)}");
            one.PrintCharacter(userInput);
            Console.ReadLine();
            
       

            //Console.WriteLine("Enter warp factor: ");
            //double warpFactor = Convert.ToDouble(Console.ReadLine());

            //new SpaceShip().Speed(warpFactor);
            //var earth = new Planet("Earth", 0.0, 0.0);
            //var alpha = new Planet("Alpha Centauri 3", 2.3, 3.7);
            //var eridani = new Planet("40 Eridani", 16.6, -35.2);

            //double distance = new Planet().Distance(0.0, 0.0, 2.3, 3.7);
            //Console.WriteLine($"{}'s spped is {distance}");




        }

        public string createNameTwo(string name)
        {
            Character One = new Character();
            One.name = name;
            return name;
        }

        public void createName()
        {
        }
    }
}
