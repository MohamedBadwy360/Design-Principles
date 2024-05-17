namespace _02_FavorCompositionOverInheritanceAfter
{
    public class Solami : ITopping
    {
        public string Title => nameof(GreenPaper);

        public decimal Price => 7.5m;
    }
}
