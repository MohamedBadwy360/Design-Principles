﻿using System;

namespace _06_LiskovSubstitutionPrinciple.After
{
    class CheckingAccount : RegularAccount
    {
        public CheckingAccount(string name, decimal balance) 
            : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("You cant withdram more than $1000");
                return;
            }
            Balance -= amount;
        }
    }
}
