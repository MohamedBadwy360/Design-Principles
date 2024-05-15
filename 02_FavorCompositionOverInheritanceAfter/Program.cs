namespace _02_FavorCompositionOverInheritanceAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = 0;
            var pizza = new Pizza();
            do
            {
                Console.Clear();
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 6)
                {
                    ITopping topping = null;
                    switch (choice)
                    {
                        case 1:
                            topping = new Tomato();
                            break;
                        case 2:
                            topping = new Chicken();
                            break;
                        case 3:
                            topping = new Cheese();
                            break;
                        case 4:
                            topping = new BlackOlive();
                            break;
                        case 5:
                            topping = new GreenPaper();
                            break;
                        case 6:
                            topping = new Solami();
                            break;
                        default:
                            break;
                    }
                    pizza.AddTopping(topping);
                    Console.WriteLine("Press any key to continue");
                }
                Console.ReadKey();
            } while (choice != 0);
            Console.WriteLine(pizza);
            Console.ReadKey();
        }

        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Available Topping");
            Console.WriteLine("------------");
            Console.WriteLine("1. Tomato");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Cheese");
            Console.WriteLine("4. Black Olives");
            Console.WriteLine("5. Green Paper");
            Console.WriteLine("6. Solami");
            Console.WriteLine("select topping: ");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }

            return choice;
        }
    }
}
