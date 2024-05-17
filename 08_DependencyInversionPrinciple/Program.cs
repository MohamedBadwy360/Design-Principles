using _08_DependencyInversionPrinciple.After;

namespace _08_DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var customers = Before.Repository.Customers;

            //foreach (var customer in customers)
            //{
            //    var notificationService = new Before.NotificationService(customer);
            //    notificationService.Notify();
            //}

            var customers = After.Repository.Customers;

            foreach (var customer in customers)
            {
                var messageServices = new List<After.IMessageService>()
                {
                    new After.SMSService { MobileNo = customer.MobileNo },
                    new After.EmailService { EmailAddress = customer.EmailAddress }
                };

                // Constructor Injection
                var notificationService = new NotificationService(messageServices);
                notificationService.Notify();


                // Property Injection
                var notificationService1 = new NotificationService1();
                notificationService1.SetServices(messageServices);
                //notificationService.Notify();


                // Method Injection
                var notificationService2 = new NotificationService2();
                //notificationService2.Notify(messageServices);
            }
        }
    }
}
