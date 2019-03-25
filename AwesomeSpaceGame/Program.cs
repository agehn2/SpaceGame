using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.WindowWidth,28);
            new GameManager().Run();
            Console.ReadKey();
            
        



        }
    }
}
