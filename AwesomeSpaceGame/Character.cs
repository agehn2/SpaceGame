﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class Character
    {
        //characteristics    
        public string name;
        public double money = 100000;
        public double leaveLeft = 50;
        double capacity=100;
        

        //constructor
        public void CreateCharacter(string userName, double money, int leaveLeft)
        {
            name = userName;
            this.money = money;
            this.leaveLeft = leaveLeft;
        }

        public string Intro(string userName)
        {
            name = userName;
            string intro = $"DS SHARPEO: Private {userName}. \n\t\tYour name sounds stupid just as you are, but it's okay. \n\t\tI will transform you to a great Soldier." +
                $"\n\t\tYou are very lucky to meet me. My name is Drill Sergeant SHARPEO \n\t\tand I am DS of the year. HAHAHAHAHAHAHAHAHAHAHAHAHAHA\n" +
                $"\n{userName}:.......The....F....\n" +
                $"\nDS SHARPEO: ATTENTION. HALF RIGHT FACE. FRONT LEAN......\n" +
                $"\n{userName}: Hey, Drill. We've done nothing but push ups and sit ups for 8 hours....I'm done. This is stupid.....\n" +
                $"\nDS SHARPEO: Aight, Private. You think you have what it takes to be in the SPACE FORCES... \n\t\tDon't blame me...blame your recruiter.";

            return intro;
        }

        public void PrintCharacter(string name, double money, double leaveLeft, double capacity, string currentLocation)
        {
            Console.Clear();         
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================");
            Console.ResetColor();
            Console.WriteLine($"Name: {name}\t\t\t Current Balance: ${money}\t\t\t Leave Days Left: {leaveLeft:f2}\n \t\t\t\t Capacity: {capacity} \t\t\t Current Location: {currentLocation}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================");
            Console.ResetColor();
        }

        public void Display()
        {
            string intro1 = "\n\n\n\t\t........3 years later. \nIt is time for you to get out of the military." +
                "\nUnfortunately, you have been busy partying and don't have enough money to get out. " +
                "\nOnly entitlement you have now is 50 days of leave. Now you have two choices." +
                "\nYou have to earn $100,000 in 50 days or reenlist\n...FOR LIFE\n\n\n\n\n\n\n\n\n Press Enter to Continue";
            Console.Write("What is your FIRST Name: ");
            string userName = Console.ReadLine();
            Console.Write("I DON'T CARE. What is your LAST Name: ");
            string userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{Intro(userInput)}");
            name = userName;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(intro1);
            Console.ReadKey();
        }

        public double Money()
        {
            return money;
        }
            //Add money to player
        public void AddMoney(double deposit)
        {
            money += deposit;
        }

        //Take money from player
        public void TakeMoney(int subtract)
        {
            money -= subtract;
        }
     
        public double TimeLeft ()
        {
            return leaveLeft;
        }

        public double LeaveLeft(double daysTravel)
        {
            leaveLeft -= daysTravel;
            return leaveLeft;
        }

        public double Capacity()
        {
            return capacity;
        }

        public void BuyItemAddWeight (double itemWeight)
        {
            if (itemWeight > capacity)
            {
                Console.WriteLine("Too Heavy, bro.");
                Console.ReadKey();
            }
            else if (itemWeight < capacity)
            {
                capacity -= itemWeight;
            }
        }

        public void SellItemRemoveWeight(double itemWeight)
        {
            capacity += itemWeight;
        }

        public bool ExitGame(bool leaveLeft)
        {
            if (this.leaveLeft >= 40)
            {
                return leaveLeft = true;
            }
            else
            {
                return leaveLeft = false;
            }
        }

    }
}


        
            

        //    //public void displayCharacter()
        //    //{
        //    //    Console.WriteLine($"Your characters name is{name}, you have {money}, you are {age} old")
        //    //}

        //}
