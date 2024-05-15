namespace _02_FavorCompositionOverInheritanceAfter
{
    public class Tomato : ITopping
    {
        public string Title => nameof(Tomato);

        public decimal Price => 3m;
    }
}
