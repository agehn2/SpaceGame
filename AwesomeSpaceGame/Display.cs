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
        
        List<string> mainMenu = new List<string>();
        int selectedMenu = 0;
        bool quit = false;
        bool valid = false;

        public void Run()
        {
            MainPage();
        }


        int selectedItem = 0;
       

        public void MainPage()
        {
        
            ASCIIMain();

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
                Thread.Sleep(00);
            }
            Console.WriteLine("\n\n\n                                         Press any key to sign your CONTRACT...");
            Console.ReadKey();
            //Console.Write("What is your name, warrior?: ");
            //string userName = Console.ReadLine();

            mainMenu.Add("Start");
            mainMenu.Add("Quit");
        
            do
            {
                Console.Clear();
                ASCIIMain();

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
                            Play();
                            break;
                    }
                } while (!quit);


            } while (!valid);


        }
        
        private bool Play()
        {
            if (selectedMenu == 0)
            {
                //new SpaceShip().Run();
                Console.Clear();
                Console.ReadLine();
                return false;
            }
            else if (selectedMenu == mainMenu.Count-1)
            {
                return quit = valid = true;
            }
            else
                return false;
        }

        public void PrintMenu()
        {
            Console.Clear();
                ASCIIMain();

            for (int i = 0; i < mainMenu.Count; ++i)
            {
                Console.WriteLine("\n\n");
                if (i==selectedMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"                                                      {mainMenu[i]}                                                    ");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
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
            selectedMenu += 1;
            if (selectedMenu >= mainMenu.Count)
            {
                selectedMenu = 0;
            }           
        }

        private void SelectPreviousItem()
        {
            selectedMenu -= 1;
            if (selectedMenu <0)
            {
                selectedMenu = mainMenu.Count;
            }
        }





    }
}
