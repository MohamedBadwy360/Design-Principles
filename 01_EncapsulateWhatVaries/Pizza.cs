namespace _01_EncapsulateWhatVaries
{
    internal class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        public static Pizza Order(string type)
        {
            Pizza pizza = Create(type);

            Prepare();
            Cut();
            Cook();

            return pizza;
        }

        private static Pizza Create(string type)
        {
            Pizza pizza;

            // often changes so we put it alone
            // if I add another type I will edit only here and the rest of code still constant
            if (type == PizzaConstants.Cheese)
            {
                pizza = new Cheese();
            }
            else if (type.Equals(PizzaConstants.Vegeterian))
            {
                pizza = new Vegeterian();
            }
            else
            {
                pizza = new Chicken();
            }

            return pizza;
        }

        private static void Prepare()
        {
            Console.Write("preparing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        private static void Cook()
        {
            Console.Write("cooking...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        private static void Cut()
        {
            Console.Write("cutting and boxing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }

        public override string ToString()
        {
            return $"\n{Title}" +
                   $"\n\tPrice: {Price.ToString("C")}";
        }
    }
}
