namespace _03_TightlyVsLooselyCoupled
{
    internal class EmailService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("Email Sent.");
        }
    }
}
