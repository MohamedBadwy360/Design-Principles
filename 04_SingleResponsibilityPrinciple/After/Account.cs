
namespace _04_SingleResponsibilityPrinciple.After
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string email, decimal balance)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;
        }

        #region Rich Domain Model
        //public void Deposit(decimal amount)
        //{
        //    var transactionMessage = "";

        //    if (amount > 0)
        //    {
        //        Balance += amount;

        //        transactionMessage =
        //            $"OK Deposit {amount.ToString("C2")}" +
        //            $", current balance {Balance.ToString("C2")}";
        //    }

        //    Send(transactionMessage, DateTime.Now);
        //}
        //public void WithDraw(decimal amount)
        //{
        //    var transactionMessage = "";


        //    if (Balance < amount)
        //    {
        //        transactionMessage =
        //        $"OVERDRAFT when trying to withdraw " +
        //        $"{Math.Abs(amount).ToString("C2")}," +
        //        $" current balance {Balance.ToString("C2")}";
        //    }
        //    else
        //    {
        //        Balance -= amount;
        //        transactionMessage =
        //            $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
        //            $", current balance {Balance.ToString("C2")}";
        //    }

        //    Send(transactionMessage, DateTime.Now);
        //}

        //public void Send(string transactionMessage, DateTime transactionDate)
        //{
        //    Console.WriteLine(
        //  $"\n\n\t\t To: {Email}" +
        //  $"\n\t\t Subject: Fake Bank Account Activity" +
        //  $"\n\n\t\t Dear {Name}," +
        //  $"\n\n\t\t\t A recent activity on your account occures at {transactionDate.ToString("yyyy-MM-dd hh:mm")}" +
        //  "\n\t\t\t\t ===> {0}" +
        //  $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
        //  $"\n\n\t\t--------------------------- ", transactionMessage);
        //}
        #endregion
    }
}
