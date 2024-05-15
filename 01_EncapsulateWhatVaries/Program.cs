namespace _01_EncapsulateWhatVaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstants.Cheese);
            Console.WriteLine(pizza);
        }
    }
}
