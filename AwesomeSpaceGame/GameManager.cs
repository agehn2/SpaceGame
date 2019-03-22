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
        Planet alphaCentauri = new Planet("Alpha Centauri 3", 25, 55); //4.37 ly
        Planet eridani = new Planet("40 Eridani", 90.5, -150.2); //38.9 ly
        Planet yZCeti = new Planet("YZ Ceti", -455.1, 900.5); //12.1  
        Planet currentPlanet;
        Planet origin;
        Planet destination;
        
        Display d = new Display();
        List<string> Difficulty = new List<string> { "Easy", "Medium", "Hard" };
        List<string> planetName = new List<string> { "Earth", "Alpha Centauri 3", "40 Eridani", "YZ Ceti" };

        int selectedItem;
        Character one = new Character();
        SpaceShip myShip;
        double warpFactor=9.0;

        public void Run()
        {
            currentPlanet = earth;
            ItemFactory itemFactory = new ItemFactory();
            d.ASCIIMain();
            bool leaveLoop = false;

            if (d.MainMenu())
            {

                Display.ChooseDifficulty();
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
                                Console.Clear();
                                one.PrintCharacter();
                                itemFactory.DisplayCurrentMarket(itemFactory.CurrentMarket(currentPlanet, earth, alphaCentauri, eridani, yZCeti ));
                                Console.ReadKey();
                                
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
            Controller(planetName);

            switch (Controller(planetName))
            {
                case 0:
                    
                    destination = earth;
                    currentPlanet = destination;
                    double travelTime = origin.Distance(origin, currentPlanet) / myShip.Speed(warpFactor);
                    Console.WriteLine(travelTime);
                    one.LeaveLeft(travelTime);
                    Console.WriteLine($"Welcome to {currentPlanet.name}.");
                    break;
                case 1:
                    destination = alphaCentauri;
                    currentPlanet = destination;
                    double travelTime1 = origin.Distance(origin, currentPlanet) / myShip.Speed(warpFactor);
                    one.LeaveLeft(travelTime1);
                    Console.WriteLine(travelTime1);
                    Console.WriteLine($"Welcome to {currentPlanet.name}.");
                    break;
                case 2:
                    destination = eridani;
                    currentPlanet = destination;
                    double travelTime2 = origin.Distance(origin, currentPlanet) / myShip.Speed(warpFactor);
                    one.LeaveLeft(travelTime2);
                    Console.WriteLine($"Welcome to {currentPlanet.name}.");
                    break;
                case 3:
                    destination = yZCeti;
                    currentPlanet = destination;
                    double travelTime3 = origin.Distance(origin, currentPlanet) / myShip.Speed(warpFactor);
                    one.LeaveLeft(travelTime3);
                    Console.WriteLine($"Welcome to {currentPlanet.name}.");

                    break;

            }

            //if (leaveLeftAfterTravel<0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("You don't have enough time to travel");
            //}
            //else if (leaveLeftAfterTravel>=0)
            //{
            //    currentPlanet = destination;
            //    Console.WriteLine($"Welcome to {currentPlanet.name}.");
            //}
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

        private void MenuOptions(List<string> list)
        {
            Console.Clear();

            for (int i = 0; i < list.Count; ++i)
            {
                Console.WriteLine("");
                if (i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                new Display().DisplayCenter($"{list[i]}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;               
            }
        }


        private int Controller(List<string> list)
        {
            bool quit = false;

            do
            {
                MenuOptions(list);
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedItem -= 1;
                        if (selectedItem < 0)
                        {
                            selectedItem = list.Count;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem += 1;
                        if (selectedItem >= list.Count)
                        {
                            selectedItem = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        quit = true;
                        break;

                }
            } while (!quit);

            return selectedItem;

        }



    }
}

                    
               // console.cursorvisible = false;
                
            