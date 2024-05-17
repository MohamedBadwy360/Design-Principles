namespace _02_FavorCompositionOverInheritance
{
    class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}"; // Pizza Cheese
        public override decimal Price => base.Price + 6m;
    }
}
