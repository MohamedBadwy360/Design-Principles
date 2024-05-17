namespace _07_InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var employees = Before.Repository.LoadEmployees();
            var employees = After.Repository.LoadEmployees();

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
        }
    }
}
