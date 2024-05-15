namespace _03_TightlyVsLooselyCoupled
{
    internal class NotificationService
    {
        private readonly INotificationMode _notificationMode;

        public NotificationService(INotificationMode notificationMode)
        {
            _notificationMode = notificationMode;
        }

        public void Notify()
        {
            _notificationMode.Send();
        }
    }

    //class NotificationService
    //{
    //    private readonly EmailService _emailService;
    //    private readonly SmsService _smsService;

    //    public NotificationService(EmailService emailService, SmsService smsService)
    //    {
    //        _emailService = emailService;
    //        _smsService = smsService;
    //    }

    //    public void Notify()
    //    {
    //        _emailService.Send();
    //        _smsService.Send();
    //    }
    //}
}
