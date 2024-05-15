namespace _03_TightlyVsLooselyCoupled
{
    internal class SmsService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("Sms Sent.");
        }
    }
}
