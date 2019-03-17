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
        public double money;
        public double age;
        int select;

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


//    //constructor
//    public void CreateCharacter(string name)
//    {
//        this.name = name;
//        this.money = 1000;
//        this.age = startAge;
//    }
//Add money to player

//    //public void displayCharacter()
//    //{
//    //    Console.WriteLine($"Your characters name is{name}, you have {money}, you are {age} old")
//    //}

//}
