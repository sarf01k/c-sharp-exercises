namespace SumNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers to sum?");
            int total = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int i = 0; i < total; i++)
            {
                Console.Write("\nEnter number {0} of {1}: ", (i + 1), total);
                sum += long.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nSum: {0}", sum);
        }
    }
}