using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class ConsoleMenu
    {
        static void Main(string[] args)
        {
            //Console.CursorVisible - false; //removes blinking line
            List<string> menuItem = new List<string>() {
               "",
               "",
               "",
           };

            while (true)
            {
                for (int i = 0; i < menuItem.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                }
                ConsoleKeyInfo ckey = Console.ReadKey();
            }

        }

        public static int drawMenu(string[] menuItems)
        {
            int selectItem = 0;
            while (true)
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (selectedItem == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(menuItems[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(menuItems[i]);
                    }
                }

                ConsoleKeyInfo cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow;
                        selectItem --;
                        break;
                    case ConsoleKey.DownArrow;
                        selectItem --;
                        break;
                }

            }
        }

    }
}


