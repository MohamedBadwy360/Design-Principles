namespace _03_TightlyVsLooselyCoupled
{
    internal class WeirdService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("blabla sent.");
        }
    }
}
