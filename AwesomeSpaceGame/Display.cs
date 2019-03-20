﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AwesomeSpaceGame
{
    class Display
    {

        List<string> mainMenu = new List<string>();  //TODO: Create enum Actions {Start, Quit};
        int selectedMenu = 0;

      

        public bool MainMenu()
        {
            mainMenu.Add("Start");
            mainMenu.Add("Quit");
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
            for (int i = 0; i < mainMenu.Count; ++i)
            {
                Console.WriteLine("\n\n");
                if (i == selectedMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine($"                                                      {mainMenu[i]}                                                    ");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void ASCIIMain()
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
                Thread.Sleep(0);
            }
            Console.WriteLine("\n\n\n                                         Press any key to sign your CONTRACT...");
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
        



    }
}
