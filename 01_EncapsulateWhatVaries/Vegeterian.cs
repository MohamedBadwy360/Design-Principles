namespace _01_EncapsulateWhatVaries
{
    internal class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Vegeterian)}";   // Pizza Vegeterian
        public override decimal Price => base.Price + 4m;
    }
}
