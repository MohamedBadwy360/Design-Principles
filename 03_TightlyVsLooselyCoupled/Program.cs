namespace _03_TightlyVsLooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationMode notificationMode = NotificationServiceFactory.Create(ENotificationMode.Sms);
            NotificationService notificationService = new NotificationService(notificationMode);
            notificationService.Notify();
        }
    }
}
