using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AwesomeSpaceGame
{
    class GameManager
    {
        Planet earth = new Planet("Earth", 0.0, 0.0);
        Planet planet1 = new Planet("Alpha Centauri 3", 25, 55); //4.37 ly
        Planet planet2 = new Planet("40 Eridani", 90.5, -150.2); //38.9 ly
        Planet planet3 = new Planet("YZ Ceti", -455.1, 900.5); //12.1  

        Planet currentPlanet;
        Planet origin;
        Planet destination;

        List<string> Difficulty = new List<string> { "Easy", "Medium", "Hard" };
        List<string> planetName = new List<string> { "Earth", "Alpha Centauri 3", "40 Eridani", "YZ Ceti" };

        Character one = new Character();
        SpaceShip myShip;
        double warpFactor;

        public void Run()
        {
            currentPlanet = earth;
            ItemFactory iF = new ItemFactory();
            Display d = new Display();
            d.ASCIIMain();
            bool leaveLoop = false;

            if (d.MainMenu())
            {

                SpaceShip.ChooseDifficulty();
                ChooseSpaceShip();
                
                one.Display();
                one.PrintCharacter();
                do
                {
                    try
                    {
                        Console.Clear();
                        one.PrintCharacter();
                        Console.WriteLine("Make a selection");
                        Console.WriteLine("D: Planet Descriptions   ||   T: Travel to planet   ||   M: Market   ||   Q: Quit");
                        var choice = Console.ReadKey(true).Key;

                        switch (choice)
                        {
                            case ConsoleKey.D:
                                Planet.PlanetDescription();
                                Console.Read();
                                break;
                            case ConsoleKey.T:
                                PlanetTravel();
                                Console.ReadKey();
                                break;
                            case ConsoleKey.M:
                                RandomNumber(10, 20);
                                // TODO: ShopAtCurrentPlanet
                                break;
                            case ConsoleKey.Q:
                                leaveLoop = true;
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                  Invalid Input                                                                           ");
                        Console.WriteLine("                                             Press enter to continute                                                                    ");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                } while (!leaveLoop);
            }      
            
        
        }

        private void PlanetTravel()
        {
            Console.Clear();
            origin = currentPlanet;
            Console.WriteLine(currentPlanet.name);
            Display display = new Display();
            display.Controller(planetName);

            double timeToTravel = origin.Distance(origin, destination) / myShip.Speed(warpFactor);
            double leaveLeftAfterTravel = one.LeaveLeft(timeToTravel);
            if (leaveLeftAfterTravel<0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have enough time to travel");
            }
            else if (leaveLeftAfterTravel>=0)
            {
                currentPlanet = destination;
                Console.WriteLine($"Welcome to {currentPlanet}.");
            }
        }

        public void ChooseSpaceShip()
        {
            bool exit = false;
            do
            {
                exit = false;
                var key = Console.ReadKey(true).Key;
                if ((key == ConsoleKey.E) || (key == ConsoleKey.M) || (key == ConsoleKey.H))
                {
                    myShip = new SpaceShip();
                    currentPlanet = earth;

                    exit = true;
                    switch (key)
                    {
                        case ConsoleKey.E:
                            myShip.SelectSpaceShip(key);
                            Console.Clear();
                            break;
                        case ConsoleKey.M:
                            myShip.SelectSpaceShip(key);
                            Console.Clear();
                            break;
                        case ConsoleKey.H:
                            myShip.SelectSpaceShip(key);
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    exit = false;
                }
            } while (!exit);
        }
        public int RandomNumber(int min, int max)  
        {  
            Random random = new Random();  
            return random.Next(min, max);  
        }  
    }       
}

                    
               // console.cursorvisible = false;
                
            