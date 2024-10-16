namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input K and N (1 < K < N):");
            decimal k = decimal.Parse(Console.ReadLine());
            decimal n = decimal.Parse(Console.ReadLine());

            if (k > 1 && n > k)
            {
                decimal kFactorial = k;
                decimal nFactorial = n;

                for (int i = (int)k - 1, j = (int)n - 1; i >= 1 && j >= 1; i--, j--)
                {
                    kFactorial *= i;
                    nFactorial *= j;
                }

                Console.WriteLine("N!/K! is {0}", nFactorial/kFactorial);
            }
            else
            {
                Console.WriteLine("Ensure 1 < K < N");
            }
        }
    }
}