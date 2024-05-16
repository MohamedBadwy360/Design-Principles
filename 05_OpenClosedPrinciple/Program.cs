namespace _05_OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var quiz = new Before.Quiz(Before.QuestionBank.Generate());

            var quiz = new After.Quiz(After.QuestionBank.Generate());

            quiz.Print();
        }
    }
}