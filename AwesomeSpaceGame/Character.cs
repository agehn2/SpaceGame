using System;
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
        const int startAge = 20;
        const int endAge = 70;
        double money = 1000;
        double age;
        int select;

        //constructor
        public void CreateCharacter(string userName, double money, int age)
        {
            name = userName;
            this.money = money;
            age = startAge;
        }

        public string Intro(string userName)
        {
            string intro = $"{userName} you are now part of the worlds greatest military in the universe,\n you will get lots of women and lots of money.......\n\n\n\n ........3 years later\n It is time for you to get out of the military.But if you get out now you will not be able to pay for “blank”.\n You are on leave for 50 days and by the end you have to earn $200,000 or reenlist\n ...FOR LIFE";
            return intro;
        }

        public void PrintCharacter(string userName)
        {
            Console.Clear();
            int age = startAge;
            Console.WriteLine($"{userName} has ${this.money} and {age} years old.");
        }

        public void Display()
        {
            Console.Write("What is your Name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"{Intro(userInput)}");
            PrintCharacter(userInput);
        }
    }
}


        //    //Add money to player
        //    public void AddMoney(double userMoney, double deposit)
        //    {
        //        money += deposit;
        
        //    }
        //    //Take money from player
        //    public void TakeMoney(int subtract)
        //    {
        //        money -= subtract;
        //    }

        //    //public void displayCharacter()
        //    //{
        //    //    Console.WriteLine($"Your characters name is{name}, you have {money}, you are {age} old")
        //    //}

        //}
