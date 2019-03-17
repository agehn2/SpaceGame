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
           Character One;
           new GameManager().runMainPage();
           new GameManager().createCharacter();
      
       
            //new Display().Run();
            //    Console.Clear();
            //Character One = new Character();
            //Console.WriteLine("What is your Name.");
            //string userInput = Console.ReadLine();
            //string name = userInput;
            //One.name = name;
            //Console.Clear();
            //Console.WriteLine($"{One.name} you are now part of the worlds greatest military in the universe,\n you will get lots of women and lots of money.......");
            //Console.WriteLine("\n\n\n\n ........3 years later\n It is time for you to get out of the military.But if you get out now you will not be able to pay for “blank”.\n You are on leave for 50 days and by the end you have to earn $200,000 or reenlist\n ...FOR LIFE");
            //Console.ReadLine();

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
