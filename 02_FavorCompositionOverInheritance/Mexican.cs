namespace _02_FavorCompositionOverInheritance
{
    class Mexican : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Mexican)}"; // Pizza Cheese
        public override decimal Price => base.Price + 3m;
    }
}
