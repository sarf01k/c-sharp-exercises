namespace SumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n and x:");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            decimal sum = 1;
            decimal factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial/(decimal)Math.Pow(x, i);
            }

            Console.WriteLine("\nThe sum of the sequence is {0}", sum);
        }
    }
}