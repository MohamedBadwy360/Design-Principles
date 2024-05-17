using System;

namespace _06_LiskovSubstitutionPrinciple.After
{
    class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name, decimal balance) 
            : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
