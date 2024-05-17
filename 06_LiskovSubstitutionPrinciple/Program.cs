namespace _06_LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var account = new Before.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000);       // will throw exception

            //var account = new After.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000);       // won't work

            var account = new After.CheckingAccount("Issam", 10_000);
            account.Withdraw(1000);
        }
    }
}
