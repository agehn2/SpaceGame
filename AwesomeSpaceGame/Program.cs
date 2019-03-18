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


            Planet earth = new Planet("Earth", 0.0, 0.0);
            Planet planet1 = new Planet("Alpha Centauri 3", 25, 55); //4.37 ly
            Planet planet2 = new Planet("40 Eridani", 90.5, -150.2); //38.9 ly
            Planet planet3 = new Planet("YZ Ceti", -455.1, 900.5); //12.1
            newMarket earthMarket = new newMarket();
            newMarket alphaCentauri = new newMarket();
            newMarket Eridani = new newMarket();
            newMarket ceti = new newMarket();
            earthMarket.AddItem(new Item("steel", 500, 5.00));

        

                    SpaceShip blueFalcon = new SpaceShip(SpaceShip.spaceShipName1, SpaceShip.startMaxCapaOne, SpaceShip.warpFactor);
                    SpaceShip m1A1 = new SpaceShip(SpaceShip.spaceShipName1, SpaceShip.startMaxCapaOne, SpaceShip.warpFactor);
                    SpaceShip spaceForceOne = new SpaceShip(SpaceShip.spaceShipName1, SpaceShip.startMaxCapaOne, SpaceShip.warpFactor);

                    Console.WriteLine($"{blueFalcon.Speed(SpaceShip.warpFactor):f2}");        // WarpFactor speed Test: 9.2 / 1649
                    Console.WriteLine($"{m1A1.Speed(SpaceShip.warpFactor2):f2}");             // WarpFactor speed Test: 9.6 / 1909
                    Console.WriteLine($"{spaceForceOne.Speed(SpaceShip.warpFactor3):f2}");    // WarpFactor speed Test  Good!

            Console.WriteLine($"Distance from {planet1} to {planet2} is {planet1.Distance(20.3, 160.6, 30.7, -350.2):f2}");         //Distance Test
            Console.WriteLine($"Distance from {planet2} to {planet3} is {planet1.Distance(-60.1, 160.6, 100.5, -350.2):f2}");       //Distance Test
            Console.WriteLine($"Distance from {planet1} to {planet2} is {planet1.Distance(160.6, 20.3, -350.2, 30.7):f2}");         //Distance Test   Name has to be revised. Calc good!

            //double duration = planet1.Distance(900.5, 0, -455.2, 0)/blueFalcon.Speed(SpaceShip.warpFactor);
            double duration = blueFalcon.Distance(earth, planet3);

            

            Console.WriteLine($"{duration:f2}"); 


            Console.WriteLine("Which planet would you like to go to?");
            int choice = int.Parse(Console.ReadLine()); 


            switch (choice)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;

            }



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

         //double duration = planet1.Distance(0, -155.1, 0, 400.5)/m1A1.Speed(SpaceShip.warpFactor2);
          //Planet earth = new Planet("Earth", 0.0, 0.0);
          //  Planet planet1 = new Planet("Alpha Centauri 3", 12.2, 20.3); //4.37 ly
          //  Planet planet2 = new Planet("40 Eridani", 90.5, -150.2); //38.9 ly
          //  Planet planet3 = new Planet("YZ Ceti", -155.1, 400.5); //12.1

        // public const double warpFactor = 9.2;
        //public const double warpFactor2 = 9.6;
        //public const double warpFactor3 = 9.99;

        //public const string spaceShipName1 = "Blue Falcon";                  //Average, $
        //public const string spaceShipName2 = "M1A1 Space Edition";           //High Cap, Average, $$
        //public const string spaceShipName3 = "Space Force One";              //High Cap, Fast, $$$

            



    }
}
