namespace _01_EncapsulateWhatVaries
{
    internal class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}";   // Pizza Chicken
        public override decimal Price => base.Price + 6m;
    }
}
