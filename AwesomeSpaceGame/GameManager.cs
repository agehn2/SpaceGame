﻿using System;
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
        List<string> Difficulty = new List<string> { "Easy", "Medium", "Hard" };
        Character one = new Character();
        SpaceShip myShip;
        public void Run()
        {
            ItemFactory iF = new ItemFactory();
            Display d = new Display();
            d.ASCIIMain();
            bool leaveLoop = false;
            if (d.MainMenu())
            {
                SpaceShip.ChooseSpaceShip();
                ChooseSpaceShip();
                Console.ReadKey();
                Console.Clear();
                one.Display();
                one.PrintCharacter();
                do
                {
                    try
                    {
                        Console.Clear();
                        one.PrintCharacter();
                        Console.WriteLine("Make a selection");
                        Console.WriteLine("1.Planet Descriptions 2,travel to planet");
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Planet.PlanetDescription();
                                break;
                            case 2:
                                Console.Clear();
                                one.PrintCharacter();
                                iF.DisplayEarthMarket();
                                Console.ReadKey();
                                break;
                            case 3:
                                // TODO: ShopAtCurrentPlanet
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

        public void ChooseSpaceShip()
        {
            bool exit = false;
            do
            {
                exit = false;
                var key = Console.ReadKey(true).Key;
                if ((key == ConsoleKey.E) || (key == ConsoleKey.M) || (key == ConsoleKey.H))
                {
                    exit = true;
                    switch (key)
                    {
                        case ConsoleKey.E:
                            myShip = new SpaceShip("Falcon",1000,9.5);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Medium");
                            break;
                        case ConsoleKey.H:
                            Console.WriteLine("Hard");
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
    }       
}

                    
               // console.cursorvisible = false;
                
            