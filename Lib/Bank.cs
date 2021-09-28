using System;
using System.Collections.Generic;
namespace Lib
{
    public class Bank
    {
        public int Id{get; set;}
        public List<Checking> CheckingAccounts {get; set;} 
        // public List<int> Owners {get; set;}

        // public Bank(int id)
        // {
        //     this.Owners = new List<int>();
        // }

    
    }

}