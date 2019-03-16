using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSpaceGame
{
    class PersonAndShip
    {
      
        public void Run()
        {
            Console.WriteLine("What is your Name?");
            string userName = Console.ReadLine();
            Character One = new Character($"{userName}");
            
            string shipName = Console.ReadLine();
            SpaceShip quikStar = new SpaceShip($"{shipName}"); 
                    
                
            

           

           
        }


    }
}
