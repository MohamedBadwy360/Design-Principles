namespace _02_FavorCompositionOverInheritance
{
    class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Vegeterian)}"; // Pizza Cheese
        public override decimal Price => base.Price + 4m;
    }
}
