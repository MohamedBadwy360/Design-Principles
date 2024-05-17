namespace _08_DependencyInversionPrinciple.After
{
    internal class NotificationService
    {
        private readonly List<IMessageService> _services;

        // Constructor Injection
        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }
        public void Notify()
        {
            foreach (IMessageService service in _services)
            {
                service.Send();
            }   
        }
    }



    internal class NotificationService1
    {
        // Property Injection
        public List<IMessageService> Services { get; private set; }

        public void Notify()
        {
            foreach (IMessageService service in Services)
            {
                service.Send();
            }
        }

        public void SetServices(List<IMessageService> services)
        {
            this.Services = services;
        }
    }


    internal class NotificationService2
    {
        // Method Injection
        public void Notify(List<IMessageService> services)
        {
            foreach (IMessageService service in services)
            {
                service.Send();
            }
        }
    }
}
