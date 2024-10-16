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
                decimal nMinusKFactorial = n - k;

                for (int i = (int)k - 1, j = (int)n - 1; i >= 1 && j >= 1; i--, j--)
                {
                    kFactorial *= i;
                    nFactorial *= j;
                }

                for (int i = (int)nMinusKFactorial - 1; i >= 1 ; i--)
                {
                    nMinusKFactorial *= i;
                }

                Console.WriteLine("N! * K!/(N - K)! is {0}", nFactorial*kFactorial/nMinusKFactorial);
            }
            else
            {
                Console.WriteLine("Ensure 1 < K < N");
            }
        }
    }
}