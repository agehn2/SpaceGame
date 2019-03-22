using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AwesomeSpaceGame
{
    class GameManager
    {
        Planet currentPlanet;
        Planet origin;
        Planet destination;
        
        Display d = new Display();
        List<string> Difficulty = new List<string> { "Easy", "Medium", "Hard" };
        List<Planet> planetList = new List<Planet>();
        List<SpaceShip> spaceShipsList = new List<SpaceShip>();
        
        int selectedItem;
        Character one = new Character();
        SpaceShip myShip;
        double warpFactor;

        public GameManager()
        {
            planetList.Add(new Planet("Earth", 0.0, 0.0));
            planetList.Add(new Planet("Alpha Centauri 3", 25.3, 55.4));
            planetList.Add(new Planet("40 Eridani", 90.5, -150.2));
            planetList.Add(new Planet("YZ Ceti", -455.1, 900.5));
            planetList.Add(new Planet("New Moon", 1500, 2300));

            Market earthMarket = planetList[0].planetMarket;
            Market alphaCentauriMarket = planetList[1].planetMarket;
            Market eridaniMarket = planetList[2].planetMarket;
            Market cetiMarket = planetList[3].planetMarket;
            Market newMoonMarket = planetList[4].planetMarket;

            AddToEarth(earthMarket);
            AddToAlphaCentauri(alphaCentauriMarket);
            AddToEridani(eridaniMarket);
            AddToCeti(cetiMarket);
            AddToNewMoon(newMoonMarket);

            spaceShipsList.Add(new SpaceShip("Blue Falcon", SpaceShip.capacityHard, SpaceShip.warpFactorHard));
            spaceShipsList.Add(new SpaceShip("M1A1 Space Edition", SpaceShip.capacityMedium, SpaceShip.warpFactorMedium));
            spaceShipsList.Add(new SpaceShip("Space Force One", SpaceShip.capacityEasy, SpaceShip.warpFactorEasy));
        }

        private void AddToNewMoon(Market newMoonMarket)
        {
            newMoonMarket.AddItem(new Item("steel: ", 260, 270, 245, 260, 2));
            newMoonMarket.AddItem(new Item("bronze: ", 295, 335, 280, 295, 4));
            newMoonMarket.AddItem(new Item("iron:   ", 315, 360, 305, 315, 5));
            newMoonMarket.AddItem(new Item("gold:  ", 365, 410, 340, 360, 3));
            newMoonMarket.AddItem(new Item("copper: ", 220, 265, 205, 215, 4));
        }

        private void AddToCeti(Market cetiMarket)
        {
            cetiMarket.AddItem(new Item("steel: ", 250, 265, 235, 250, 2));
            cetiMarket.AddItem(new Item("bronze: ", 410, 465, 390, 405, 4));
            cetiMarket.AddItem(new Item("iron:   ", 420, 500, 410, 420, 5));
            cetiMarket.AddItem(new Item("gold:  ", 315, 360, 300, 315, 3));
            cetiMarket.AddItem(new Item("copper: ", 320, 370, 300, 310, 4));
            cetiMarket.AddItem(new Item("mithril", 200, 300, 180, 200, 8));
        }

        private void AddToEridani(Market erdaniMarket)
        {
            erdaniMarket.AddItem(new Item("steel: ", 120, 130, 105, 120, 2));
            erdaniMarket.AddItem(new Item("bronze: ", 210, 255, 195, 210, 4));
            erdaniMarket.AddItem(new Item("iron:   ", 215, 250, 200, 215, 5));
            erdaniMarket.AddItem(new Item("gold:  ", 255, 295, 240, 255, 3));
            erdaniMarket.AddItem(new Item("copper: ", 270, 305, 255, 265, 4));
        }

        private void AddToAlphaCentauri(Market alphaCentauriMarket)
        {
            alphaCentauriMarket.AddItem(new Item("steel: ", 100, 110, 90, 100, 2));
            alphaCentauriMarket.AddItem(new Item("bronze: ", 255, 290, 240, 255, 4));
            alphaCentauriMarket.AddItem(new Item("iron:   ", 265, 305, 245, 255, 5));
            alphaCentauriMarket.AddItem(new Item("gold:  ", 175, 200, 140, 150, 3));
            alphaCentauriMarket.AddItem(new Item("copper: ", 375, 415, 360, 375, 4));
        }

        private void AddToEarth(Market earthMarket)
        {
            earthMarket.AddItem(new Item("steel:  ", 75, 80, 65, 70, 2));
            earthMarket.AddItem(new Item("bronze: ", 335, 395, 320, 335, 4));
            earthMarket.AddItem(new Item("iron:   ", 345, 395, 335, 345, 5));
            earthMarket.AddItem(new Item("gold:   ", 205, 245, 160, 175, 3));
            earthMarket.AddItem(new Item("copper: ", 410, 480, 400, 410, 4));
            earthMarket.AddItem(new Item("mithril:", 550, 850, 400, 450, 8));
        }

        public void Run()
        {
            currentPlanet = planetList[0];
            
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
                                
                                //itemFactory.DisplayCurrentMarket(iF.CurrentMarket(currentPlanet, planetList[0], planetList[1], planetList[2], planetList[3]));
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
            Controller(planetList);

            
            switch (Controller(planetList))
            {
                case 0:
                    TravelToChoice(0);
                    break;
                case 1:
                    TravelToChoice(1);
                    break;
                case 2:
                    TravelToChoice(2);
                    break;
                case 3:
                    TravelToChoice(3);
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

        private void TravelToChoice(int i)
        {
            destination = planetList[i];
            currentPlanet = destination;
            double travelTime = origin.Distance(origin, currentPlanet) / myShip.Speed(warpFactor);//TODO: WarpFactor
            Console.WriteLine(travelTime);
            one.LeaveLeft(travelTime);
            Console.WriteLine($"Welcome to {planetList[i].name}.");
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
                    currentPlanet = planetList[0];

                    exit = true;
                    switch (key)
                    {
                        case ConsoleKey.E:
                            myShip=spaceShipsList[2];
                            Console.Clear();
                            break;
                        case ConsoleKey.M:
                            myShip = spaceShipsList[1];
                            Console.Clear();
                            break;
                        case ConsoleKey.H:
                            myShip = spaceShipsList[0];
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

        private void MenuOptions(List<Planet> list)
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
                new Display().DisplayCenter($"{list[i].name}   ||   {currentPlanet.Distance(currentPlanet,list[i])/myShip.Speed(warpFactor):f2}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;               
            }
        }


        private int Controller(List<Planet> list)
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
                






            