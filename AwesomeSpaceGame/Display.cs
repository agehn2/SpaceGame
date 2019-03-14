using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class Display
    {
        public void title()
        { 
          Console.Title = "";
          Console.ForegroundColor = ConsoleColor.Green;
          string title = @"    _____                          __  __                __         
                              / ___/____  ____ _________     / / / /_  ____________/ /__  _____
                              \__ \/ __ \/ __ `/ ___/ _ \   / /_/ / / / / ___/ ___/ / _ \/ ___/
                             ___/ / /_/ / /_/ / /__/  __/  / __  / /_/ (__  |__  ) /  __/ /    
                            /____/ .___/\__,_/\___/\___/  /_/ /_/\__,_/____/____/_/\___/_/     
                                /_/                                                            ";

            Console.WriteLine(title);
            Console.ResetColor();
            Console.ReadKey();
            
        }



    }
}
