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
        int selectedMenu = 0;



        public bool MainMenu()
        {
            mainMenu.Add("Start");
            mainMenu.Add("Quit ");
            Console.Clear();
            return UserInputHandler();
        }

        private bool UserInputHandler()
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
            string script = "\n\n\nEarth needs YOU..." +
                        "\nFuture WARRIOR" +
                        "\nLOYALTY, DUTY, RESPECT," +
                        "\nSELFLESS SERVICE, HONOR, INTEGRITY" +
                        "\nand.....PERSONAL.....COURAGE!! " +
                        "\nVisit the nearest ARMY recruiting center!! "+
                        "\n\n\nPress any key to sign your CONTRACT...";
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

        public void DisplayDiffuculty(string header, List<string> name)
        {
            
            Selector.ArrowKeyOptionMenu("Choose Your Difficulty:", name);
        }
    }
}
