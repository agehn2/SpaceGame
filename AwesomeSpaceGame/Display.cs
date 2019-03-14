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
        int selectedItem = 0;
            List<string> mainMenu = new List<string>();

        public void Run()
        {
            MainPage();
        }


        private void MainPage()
        {
        
            ASCIIMain();
            Console.WriteLine("\n\n\n                                         Press any key to sign your CONTRACT...");

            string script = "\n\n\n" +
                "\n                                                   Earth needs YOU... " +
                "\n                                                    Future WARRIOR" +
                "\n                                               LOYALTY, DUTY, RESPECT," +
                "\n                                         SELFLESS SERVICE, HONOR, INTEGRITY" +
                "\n                                             and.....PERSONAL.....COURAGE!! " +
                "\n                                     Visit the nearest ARMY recruiting center!! ";
            foreach (char c in script)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(c);
                Thread.Sleep(40);
            }
            Console.ReadKey();

            bool valid = false;
            Console.Write("What is your name, warrior?: ");
            string userName = Console.ReadLine();

        
            do
            {
                Console.Clear();
                ASCIIMain();
                mainMenu.Add("Start");
                mainMenu.Add("");
                mainMenu.Add("Quit");
                for (int i = 0; i < mainMenu.Count; ++i)
                {
                    if (selectedItem == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    Console.WriteLine(mainMenu[selectedItem]);
                }                

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.DownArrow:
                        SelectNextItem();
                        break;
                    case ConsoleKey.Enter:
                        break;
                }

            } while (!valid);


        }

        private static void ASCIIMain()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string title = @"
                               _____                          __  __                __         
                              / ___/____  ____ _________     / / / /_  ____________/ /__  _____
                              \__ \/ __ \/ __ `/ ___/ _ \   / /_/ / / / / ___/ ___/ / _ \/ ___/
                             ___/ / /_/ / /_/ / /__/  __/  / __  / /_/ (__  |__  ) /  __/ /    
                            /____/ .___/\__,_/\___/\___/  /_/ /_/\__,_/____/____/_/\___/_/     
                                /_/                                                            ";

            Console.WriteLine(title);
            Console.ResetColor();
        }

        private void SelectNextItem()
        {
            selectedItem += 1;
            if (selectedItem >= mainMenu.Count)
            {
                selectedItem = 0;
            }           
        }




    }
}
