using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AwesomeSpaceGame
{
    class Display
    {
        List<string> Difficulty = new List<string> {"Easy", "Medium", "Hard"};
        List<string> mainMenu = new List<string>();  //TODO: Create enum Actions {Start, Quit};
        List<string> MarketMenu = new List<string>(); //Buy, Sell, Inventory

        int selectedMenu = 0;
        int selectedItem = 0;
        protected static int origRow;
        protected static int origCol;

        public bool MainMenu()
        {
            mainMenu.Add("Start");
            mainMenu.Add("Quit ");
            Console.Clear();
            return UserInputHandler();
        }

        public bool UserInputHandler()
        {
            bool quit = false;
            do
            {
                PrintMenu();
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        SelectPreviousItem();
                        break;
                    case ConsoleKey.DownArrow:
                        SelectNextItem();
                        break;
                    case ConsoleKey.Enter:
                        quit = true;
                        break;

                }
            } while (!quit);
            return (selectedMenu == 0);
        }

        private bool Play()
        {
            if (selectedMenu == 0)
            {

                Console.Clear();
                return true;
            }
            else if (selectedMenu == mainMenu.Count - 1)
            {

                return true;  //TODO: Terminate program
            }
            else
                return false;
        }

        public void PrintMenu()
        {
            Console.Clear();
            DisplayGameName();
            Console.ResetColor();
            Console.WriteLine("\n\n");
            DisplayCenter("Main Menu");
            Console.ForegroundColor = ConsoleColor.Red;
            DisplayCenter("=============");
            Console.ResetColor();

            for (int i = 0; i < mainMenu.Count; ++i)
            {
                Console.WriteLine("");
                if (i == selectedMenu)
                {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                }
                DisplayCenter($"{mainMenu[i]}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void DisplayCenter(string s)
        {
            if (s.Length <= Console.WindowWidth)
            {
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2,
                Console.CursorTop);
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(s);
            }
        }

        public void ASCIIMain()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string title = @"
                               _____                       ______                      
                              /  ___|                      |  ___|                     
                              \ `--. _ __   __ _  ___ ___  | |_ ___  _ __ ___ ___  ___ 
                               `--. \ '_ \ / _` |/ __/ _ \ |  _/ _ \| '__/ __/ _ \/ __|
                              /\__/ / |_) | (_| | (_|  __/ | || (_) | | | (_|  __/\__ \
                              \____/| .__/ \__,_|\___\___| \_| \___/|_|  \___\___||___/
                                    | |                                                
                                    |_|                                                ";

            Console.WriteLine(title);
            Console.ResetColor();
            string[] script = new[] { "\n\n\n", " Earth needs YOU...",
                        "Future WARRIOR" ,
                        "LOYALTY, DUTY, RESPECT," ,
                        "SELFLESS SERVICE, HONOR, INTEGRITY" ,
                        "and.....PERSONAL.....COURAGE!! " ,
                        "Visit the nearest ARMY recruiting center!! ",
                        "\n\n", "Press any key to sign your CONTRACT..." };
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            foreach (var s in script)
            {
                DisplayCenter(s);
            }

            Console.ResetColor();
            Console.ReadKey();
        }

        private void SelectNextItem()
        {
            selectedMenu += 1;
            if (selectedMenu >= mainMenu.Count)
            {
                selectedMenu = 0;

            }
        }

        private void SelectPreviousItem()
        {
            selectedMenu -= 1;
            if (selectedMenu < 0)
            {
                selectedMenu = mainMenu.Count;
            }
        }

        enum QuitGame
        {
            UserQuit,
            LostGame,
            WonGame
        }

        private void DisplayGameName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string title = @"
                               _____                       ______                      
                              /  ___|                      |  ___|                     
                              \ `--. _ __   __ _  ___ ___  | |_ ___  _ __ ___ ___  ___ 
                               `--. \ '_ \ / _` |/ __/ _ \ |  _/ _ \| '__/ __/ _ \/ __|
                              /\__/ / |_) | (_| | (_|  __/ | || (_) | | | (_|  __/\__ \
                              \____/| .__/ \__,_|\___\___| \_| \___/|_|  \___\___||___/
                                    | |                                                
                                    |_|                                                ";

            Console.WriteLine(title);
            Console.ResetColor();

        }
       
         public static void ChooseDifficulty()
        {
            Console.WriteLine("Choose your difficulty:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================");
            Console.ResetColor();
            Console.WriteLine(" Easy\t |E|\n Medium\t |M|\n Hard\t |H|");
            Console.WriteLine("\nSelection:");
        }

        public void MenuOptions(List<string> list)
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
                DisplayCenter($"{list[i]}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }      
        }
    

        public int Controller (List<string> list)
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

       

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void MarketSelectionText(List<Item> inventory)
        {
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;
            int nextItem = 0;
            WriteAt("\n\nMake A Selection:", 0, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            WriteAt("=================",0, 4);
            Console.ResetColor();
            WriteAt(" B. Buy Item\n S. Sell Item\n V. View Inventory\n M. Exit Shop", 0, 5);
            WriteAt("Inventory: ", 36, 4);
            for (int i = 0; i < inventory.Count; i++)
            {
                WriteAt($"{inventory[i].itemName}()", 48, 4 + nextItem);
                nextItem = (nextItem + 1);
            }
        }
    }
}

            
            



