﻿using System.Diagnostics.Metrics;

namespace _04_SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP(); 
            TestWithSRP();
        }

        private static void TestWithoutSRP()
        {
            var account =
                new Before.Account("Reem", "reem@example.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }

        private static void TestWithSRP()
        {
            var account =
                new After.Account("Reem", "reem@example.com", 10000m);

            var accountService = new After.AccountService();
            accountService.Deposit(account, 500);
            accountService.WithDraw(account, 11000);
        }
    }
}
