using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    static class Selector
    {
        
        public static int ArrowKeyOptionMenu(string header, List<string> options)
        {
            var fg = Console.ForegroundColor;
            var bg = Console.BackgroundColor;

            void Highlight()
            {
                Console.ForegroundColor = bg;
                Console.BackgroundColor = fg;
            }

            void ResetHighlight()
            {
                Console.ForegroundColor = fg;
                Console.BackgroundColor = bg;
            }

            int selector = 0;
            int count = options.Count;


            do
            {
                Console.Clear();
                Console.WriteLine(header);

                for (int i = 0; i < count; ++i)
                {
                    if (i == selector) Highlight();

                    Console.WriteLine($"  {options[i]}");

                    ResetHighlight();
                }

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        selector++;
                        selector %= count;
                        break;
                    case ConsoleKey.UpArrow:
                        selector--;
                        selector = (selector + count) % count;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.Enter:
                        return selector;
                    case ConsoleKey.Q:
                        return 0;
                }
            } while (true);
        }  
    }
}

