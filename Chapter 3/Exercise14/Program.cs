namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 & 100: ");
            int n = int.Parse(Console.ReadLine());

            int divCounter = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                divCounter += (n % i == 0) ? 1 : 0;
            }

            Console.WriteLine("{0} is " + (divCounter > 0 ? "not prime." : "prime."), n);
        }
    }
}