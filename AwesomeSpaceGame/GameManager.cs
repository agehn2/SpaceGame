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
        //List<string> Difficulty = new List<string> { "Easy", "Medium", "Hard" };
        List<Planet> planetList = new List<Planet>();
        List<SpaceShip> spaceShipsList = new List<SpaceShip>();
        List<Item> inventory = new List<Item>();


        int selectedItem;
        Character one = new Character();
        SpaceShip myShip;
        double inventoryMaxCapacity;
        double warpFactor = 9.5;

        public GameManager()
        {
            //inventory.Add(new Item("steel:   ", 260, 270, 245, 260, 2));
            //inventory.Add(new Item("bronze:  ", 260, 270, 245, 260, 4));
            //inventory.Add(new Item("iron:    ", 260, 270, 245, 260, 5));
            //inventory.Add(new Item("gold:    ", 260, 270, 245, 260, 3));
            //inventory.Add(new Item("copper:  ", 260, 270, 245, 260, 4));
            //TODO: Initial weight capacity has to be adjusted based on inventory items.


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

            AddToEarth(ref earthMarket);
            AddToAlphaCentauri(ref alphaCentauriMarket);
            AddToEridani(ref eridaniMarket);
            AddToCeti(ref cetiMarket);
            AddToNewMoon(ref newMoonMarket);

            spaceShipsList.Add(new SpaceShip("Blue Falcon", SpaceShip.capacityHard, SpaceShip.warpFactorHard));
            spaceShipsList.Add(new SpaceShip("M1A1 Space Edition", SpaceShip.capacityMedium, SpaceShip.warpFactorMedium));
            spaceShipsList.Add(new SpaceShip("Space Force One", SpaceShip.capacityEasy, SpaceShip.warpFactorEasy));
        }





        private void AddToNewMoon(ref Market newMoonMarket)
        {
            newMoonMarket.AddItem(new Item("steel   ", 260, 270, 245, 260, 2));
            newMoonMarket.AddItem(new Item("bronze  ", 295, 335, 280, 295, 4));
            newMoonMarket.AddItem(new Item("iron    ", 315, 360, 305, 315, 5));
            newMoonMarket.AddItem(new Item("gold    ", 365, 410, 340, 360, 3));
            newMoonMarket.AddItem(new Item("copper  ", 220, 265, 205, 215, 4));
        }

        private void AddToCeti(ref Market cetiMarket)
        {
            cetiMarket.AddItem(new Item("steel   ", 250, 265, 235, 250, 2));
            cetiMarket.AddItem(new Item("bronze  ", 410, 465, 390, 405, 4));
            cetiMarket.AddItem(new Item("iron    ", 420, 500, 410, 420, 5));
            cetiMarket.AddItem(new Item("gold    ", 315, 360, 300, 315, 3));
            cetiMarket.AddItem(new Item("copper  ", 320, 370, 300, 310, 4));
            cetiMarket.AddItem(new Item("mithril ", 200, 300, 180, 200, 8));
        }

        private void AddToEridani(ref Market erdaniMarket)
        {
            erdaniMarket.AddItem(new Item("steel   ", 120, 130, 105, 120, 2));
            erdaniMarket.AddItem(new Item("bronze  ", 210, 255, 195, 210, 4));
            erdaniMarket.AddItem(new Item("iron    ", 215, 250, 200, 215, 5));
            erdaniMarket.AddItem(new Item("gold    ", 255, 295, 240, 255, 3));
            erdaniMarket.AddItem(new Item("copper  ", 270, 305, 255, 265, 4));
        }

        private void AddToAlphaCentauri(ref Market alphaCentauriMarket)
        {
            alphaCentauriMarket.AddItem(new Item("steel   ", 100, 110, 90, 100, 2));
            alphaCentauriMarket.AddItem(new Item("bronze  ", 255, 290, 240, 255, 4));
            alphaCentauriMarket.AddItem(new Item("iron    ", 265, 305, 245, 255, 5));
            alphaCentauriMarket.AddItem(new Item("gold    ", 175, 200, 140, 150, 3));
            alphaCentauriMarket.AddItem(new Item("copper  ", 375, 415, 360, 375, 4));
        }

        private void AddToEarth(ref Market earthMarket)
        {

            earthMarket.AddItem(new Item("steel   ", 75, 80, 65, 70, 2));
            earthMarket.AddItem(new Item("bronze  ", 335, 395, 320, 335, 4));
            earthMarket.AddItem(new Item("iron    ", 345, 395, 335, 345, 5));
            earthMarket.AddItem(new Item("gold    ", 205, 245, 160, 175, 3));
            earthMarket.AddItem(new Item("copper  ", 410, 480, 400, 410, 4));
            earthMarket.AddItem(new Item("mithril ", 550, 850, 400, 450, 8));

        }

        bool leaveLoop = false;
        public void Run()
        {
            currentPlanet = planetList[0];
            d.ASCIIMain();

            if (d.MainMenu())
            {
                Display.ChooseDifficulty();
                ChooseSpaceShip();
                //Creates Capacity for inventory, was having trouble using spaceships, so im building inventory seperate
                //but it still takes capacity from spaceship.
                // TODO: Make IC take capacity from selected spaceship for game!
                inventoryMaxCapacity = spaceShipsList[1].spaceShipHard.capacitySpaceShip;

                one.Display();
                PrintCurrentStatus();
                    do
                    {
                        try
                        {
                            Console.Clear();
                            PrintCurrentStatus();
                            Console.WriteLine("Make a selection");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("========================================================================================================================");
                            Console.ResetColor();
                            Console.WriteLine("D: Planet Descriptions   ||   T: Travel to planet   ||   M: Market   ||   Q: Quit");
                            var choice = Console.ReadKey(true).Key;

                        switch (choice)
                        {
                            case ConsoleKey.D:
                                Planet.PlanetDescription();
                                Console.ReadKey();
                                break;
                            case ConsoleKey.T:
                                PlanetTravel();
                                Console.ReadKey();
                                break;
                            case ConsoleKey.M:
                                Console.Clear();
                                PrintCurrentStatus();
                                MarketController(ChoosesCurrentMarket(currentPlanet, planetList[0], planetList[1], planetList[2], planetList[3]));
                                Display.MarketSelectionText(inventory);
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
                        one.ExitGame(leaveLoop);
                    } while (!leaveLoop);
            }


        }

        private void PrintCurrentStatus()
        {
            one.PrintCharacter(one.name, one.Money(), one.TimeLeft(), one.Capacity(), currentPlanet.name);
        }

        public void PlanetTravel()
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
                case 4:
                    TravelToChoice(4);
                    break;
            }

        }

        private void TravelToChoice(int i)
        {
            destination = planetList[i];
            currentPlanet = destination;
            double travelTime = origin.Distance(origin, currentPlanet) / myShip.Speed(warpFactor);//TODO: WarpFactor change based on Difficulty
            Console.WriteLine($"{travelTime:f2}");
            one.LeaveLeft(travelTime);
            if (travelTime >= one.leaveLeft)
            {
                Console.Clear();
                EndOfGame();
                Console.ReadKey();
                leaveLoop = true;
            }
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
                            warpFactor = myShip.SelectWarpFactor(0);
                            Console.Clear();
                            break;
                        case ConsoleKey.M:
                            warpFactor = myShip.SelectWarpFactor(1);
                            Console.Clear();
                            break;
                        case ConsoleKey.H:
                            warpFactor = myShip.SelectWarpFactor(2);
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

        private void MenuOptions(List<Planet> list, Planet planet)
        {
            Console.Clear();
            Console.WriteLine("");
            d.DisplayCenter($"\tYou are about to leave {currentPlanet.name}. Select your destination.");
            var index = planetList.FindIndex(i => i.name == currentPlanet.name);
            if (index >= 0)
            {
                planetList.RemoveAt(index);
            }
            for (int i = 0; i < list.Count; ++i)
            {
                Console.WriteLine("");
                if (i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                d.DisplayCenter($"{list[i].name}\t\t\t||\t{currentPlanet.Distance(currentPlanet, list[i]) / myShip.Speed(warpFactor):f2}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            planetList.Add(currentPlanet);
        }


        private int Controller(List<Planet> list)
        {
            bool quit = false;

            do
            {
                MenuOptions(list, currentPlanet);
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

        //This will make the current market the one being used for methods depending on what planet your on
        public Market ChoosesCurrentMarket(Planet currentPlanet, Planet earth, Planet alphaCentauri, Planet eridani, Planet ceti)
        {
            if (currentPlanet == earth)
            {
                Console.WriteLine("earths market");
                return planetList[0].planetMarket;
            }
            else if (currentPlanet == alphaCentauri)
            {
                Console.WriteLine("Alpha Centauri Market");

                return planetList[1].planetMarket;
            }
            else if (currentPlanet == eridani)
            {
                Console.WriteLine("Eridani Market");

                return planetList[2].planetMarket;
            }
            else if (currentPlanet == ceti)
            {
                Console.WriteLine("Ceti Market");

                return planetList[3].planetMarket;
            }
            else
            {
                Console.WriteLine("New planet Market");

                return planetList[4].planetMarket;

            }

        }

        //Navigate current Market
        public void MarketInterface(Market currentMarket)
        {
            Console.Clear();
            PrintCurrentStatus();
            Console.WriteLine("\nItem Name\t\t     Price of Item\t\t      Sell Price\t\t       Units");
            Console.WriteLine("========================================================================================================================");
            for (int i = 0; i < currentMarket.items.Count; ++i)
            {

                if (i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.WriteLine($"{currentMarket.items[i].itemName}\t --\t\t  {currentMarket.items[i].askPrice}\t\t --\t\t  {currentMarket.items[i].offerPrice}\t\t --\t\t  {currentMarket.items[i].weight}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Display.MarketSelectionText(inventory);

        }
        //Displays CurrentMarket
        public int MarketController(Market currentMarket)
        {
            bool quit = false;

            do
            {
                MarketInterface(currentMarket);
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedItem -= 1;
                        if (selectedItem < 0)
                        {
                            selectedItem = currentMarket.items.Count;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem += 1;
                        if (selectedItem >= currentMarket.items.Count)
                        {
                            selectedItem = 0;
                        }
                        break;
                    case ConsoleKey.B:
                        if (currentMarket.items[selectedItem].askPrice < one.Money())
                        {
                            inventory.Add(currentMarket.items[selectedItem]);
                            one.TakeMoney(currentMarket.items[selectedItem].askPrice);
                            one.BuyItemAddWeight(currentMarket.items[selectedItem].weight);
                        }
                        else if (currentMarket.items[selectedItem].askPrice < one.Money())
                        {
                            Console.WriteLine($"Your current balance is {one.Money()}. Not enough to execute the requested transaction.");
                        }
                        break;
                    case ConsoleKey.S:
                        var index = inventory.FindIndex(i => i.itemName == currentMarket.items[selectedItem].itemName);
                        if (index >= 0)
                        {
                            inventory.RemoveAt(index);
                            one.AddMoney(currentMarket.items[selectedItem].offerPrice);
                            one.SellItemRemoveWeight(currentMarket.items[selectedItem].weight);
                        }
                        break;
                    case ConsoleKey.E:
                        quit = true;
                        break;

                }
            } while (!quit);

            return selectedItem;




        }

        public void InventoryInterface(List<Item> inventory)
        {
            Console.Clear();
            PrintCurrentStatus();
            Console.WriteLine("\nItem Name\t\t     Price of Item\t\t      Sell Price\t\t       Units");
            Console.WriteLine("========================================================================================================================");
            for (int i = 0; i < inventory.Count; ++i)
            {

                if (i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.WriteLine($"{inventory[i].itemName}    {inventory[i].askPrice}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }
        public int InventoryController(List<Item> inventory)
        {
            bool quit = false;

            do
            {
                InventoryInterface(inventory);
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedItem -= 1;
                        if (selectedItem < 0)
                        {
                            selectedItem = inventory.Count;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem += 1;
                        if (selectedItem >= inventory.Count)
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

        public void EndOfGame()
        {
            if (one.money >= 100000)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                d.DisplayCenter("Congratulations");
                d.DisplayCenter("You Won");
            }
            else
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
                d.DisplayCenter("Game Over");
                d.DisplayCenter("You Lose");
            }
        }

    }
}







// console.cursorvisible = false;







