namespace HW3_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3, b = 7, c = 9;

            Console.WriteLine(Calculate(a, b, c));

            Console.ReadLine();
        }

        static string Calculate(double a, double b, double c)
        {
            return $"{a / 5}, {b / 5}, {c / 5}";
        }
    }
}
