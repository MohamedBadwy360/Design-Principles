namespace _02_FavorCompositionOverInheritanceAfter
{
    public class GreenPaper : ITopping
    {
        public string Title => nameof(GreenPaper);

        public decimal Price => 2.5m;
    }
}
