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
        string name;
        double age;
        double money;

        //constructor
        public Character(string name)
        {
            this.name = name;
            age = 20;
            money = 1000;
        }
        //Add money to player
        public void AddMoney(int deposit)
        {
            money += deposit;
        }
        //Take money from player
        public void TakeMoney(int subtract)
        {
            money -= subtract;
        }

    }
}
