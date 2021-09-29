using System;
using System.Collections.Generic;
namespace Lib
{
    public class Checking
    {
        public int Id{get; set;}
        public string Owner{get; set;}
        public int Balance {get; set;}
        
        public void Deposit(int amount)
        {
            Balance += amount;
             Console.WriteLine($"You have been deposited: {amount}");
        }

        public void Withdraw(int amount)
        {   if(amount <= Balance && Balance - amount >= 0)
                Balance -= amount;
            else if(Balance < 0)
            Balance -= 75;
            Console.WriteLine("You have been charged a 75$ Overdraft fee");
        }
    }

}