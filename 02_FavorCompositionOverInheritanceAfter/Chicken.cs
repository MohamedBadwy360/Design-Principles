namespace _02_FavorCompositionOverInheritanceAfter
{
    public class Chicken : ITopping
    {
        public string Title => nameof(Chicken);

        public decimal Price => 6m;
    }
}
