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
        const int startAge = 20;
        double money;
        double age;
        int select;


        //constructor
        public Character(string name)
        {
            this.name = name;
            money = 1000;
            age = startAge;

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
