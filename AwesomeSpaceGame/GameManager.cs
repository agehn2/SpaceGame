using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class GameManager
    {
        public void runMainPage()
        {
            new Display().PrintMenu();
            new Display().MainPage();
            Console.ReadKey();
        }

        public void createCharacter()
        {
            Character One = new Character();
            Console.WriteLine("What is your Name.");
            string userInput = Console.ReadLine();
            string name = userInput;
            One.name = name;
        }
        public void readStory()
        {
        Console.Clear();
        Console.WriteLine($"{One.name} you are now part of the worlds greatest military in the universe,\n you will get lots of women and lots of money.......");
        Console.WriteLine("\n\n\n\n ........3 years later\n It is time for you to get out of the military.But if you get out now you will not be able to pay for “blank”.\n You are on leave for 50 days and by the end you have to earn $200,000 or reenlist\n ...FOR LIFE");
        Console.ReadLine();
        }
















    }
}
