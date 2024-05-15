namespace _02_FavorCompositionOverInheritanceAfter
{
    class Pizza
    {
        public virtual decimal Price => 10m;

        public List<ITopping> Toppings { get; private set; } = new List<ITopping>();

        public void AddTopping(ITopping topping) => Toppings.Add(topping);


        private decimal Calculate()
        {
            var total = Price;
            foreach (var item in Toppings)
            {
                total += item.Price;
            }
            return total;
        }
        public override string ToString()
        {
            var output = $"\n{nameof(Pizza)}";
            output += $"\n\tBase Price: ({Price.ToString("C")})";
            foreach (var topping in Toppings)
            {
                output += $"\n\t {topping.Title} ({topping.Price.ToString("C")})";
            }
            output += "\n-----------------------";
            output += $"\nTotal: {Calculate().ToString("C")}";
            return output;
        }
    }
}
