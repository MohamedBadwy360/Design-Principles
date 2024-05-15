namespace _03_TightlyVsLooselyCoupled
{
    internal class NotificationServiceFactory
    {
        public static INotificationMode Create(ENotificationMode mode)
        {
            switch (mode)
            {
                case ENotificationMode.Email:
                    return new EmailService();
                case ENotificationMode.Sms:
                    return new SmsService();
                case ENotificationMode.Weird:
                    return new WeirdService();
                default:
                    return new EmailService();
            }
        }
    }
}
