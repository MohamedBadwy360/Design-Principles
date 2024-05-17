namespace _08_DependencyInversionPrinciple.After
{
    internal class EmailService : IMessageService
    {
        public string EmailAddress { get; set; }
         

        public void Send()
        {
            Console.WriteLine($"e-mail is sent to {EmailAddress}");
        }
    }
}
