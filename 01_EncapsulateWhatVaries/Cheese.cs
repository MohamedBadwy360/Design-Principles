namespace _01_EncapsulateWhatVaries
{
    internal class Cheese : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Cheese)}";   // Pizza Cheese
        public override decimal Price => base.Price + 3m;
    }
}
