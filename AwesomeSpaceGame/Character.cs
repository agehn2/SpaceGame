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
        double money = 1000;
        double leaveLeft = 50;
        

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
            string intro = $"DS SHARPEO: Private {userName}. Your name sounds stupid, you piece of... but it's okay." +
                $"Forget what .\n .......\n\n\n\n\n\n\n\n\n\n\n\n\n ........3 years later\n It is time for you to get out of the military.But if you get out now you will not be able to pay for “blank”.\n You are on leave for 50 days and by the end you have to earn $200,000 or reenlist\n ...FOR LIFE\n\n\n\n\n\n\n\n\n Press Enter to Continue";
            return intro;
        }

        public void PrintCharacter()
        {
            Console.Clear();         
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================");
            Console.ResetColor();
            Console.WriteLine($"Name: {name}\t\t\t\t\t ${money}\t\t\t\t\t Leave Days Left: {leaveLeft} ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================");
            Console.ResetColor();
        }

        public void Display()
        {
            Console.Write("What is your FIRST Name: ");
            Console.ReadLine();
            Console.Write("I DON'T CARE. What is your LAST Name: ");
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

        public double LeaveLeft(double daysTravel)
        {
            leaveLeft -= daysTravel;
            return leaveLeft;
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
