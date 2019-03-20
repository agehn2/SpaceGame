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
        double age = 20;
        

        //constructor
        public void CreateCharacter(string userName, double money, int age)
        {
            name = userName;
            this.money = money;
            this.age = startAge;
        }

        public string Intro(string userName)
        {
            string intro = $"{userName} you are now part of the worlds greatest military in the universe,\n you will get lots of women and lots of money.......\n\n\n\n\n\n\n\n\n\n\n\n\n ........3 years later\n It is time for you to get out of the military.But if you get out now you will not be able to pay for “blank”.\n You are on leave for 50 days and by the end you have to earn $200,000 or reenlist\n ...FOR LIFE\n\n\n\n\n\n\n\n\n Press Enter to Continue";
            return intro;
        }

        public void PrintCharacter()
        {
            Console.Clear();         
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================");
            Console.ResetColor();
            Console.WriteLine($"Name: {this.name}\t\t\t\t\t ${this.money}\t\t\t\t\t Age: {this.age} ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================");
            Console.ResetColor();
        }

        public void Display()
        {
            Console.Write("What is your Name: ");
            string userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{Intro(userInput)}");
            name = userInput;
            Console.ReadKey();
        }
            //Add money to player
        public void AddMoney( double deposit)
        {
            money += deposit;
        }

        public void AddAge(double ageUp)
        {
            age += ageUp;   
        }

        //Take money from player
        public void TakeMoney(int subtract)
        {
            money -= subtract;
        }
     
            
    }
}


        
            

        //    //public void displayCharacter()
        //    //{
        //    //    Console.WriteLine($"Your characters name is{name}, you have {money}, you are {age} old")
        //    //}

        //}
