namespace CatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            decimal catalan = FindFactorial(2*num)/FindFactorial(num+1)*FindFactorial(num);

            Console.WriteLine($"Catalan number {num} is {catalan}");
        }

        private static decimal FindFactorial(decimal num)
        {
            decimal theFactorial = num;
            for (int i = (int)num - 1; i >= 1; i--)
            {
                theFactorial *= i;
            }

            return theFactorial;
        }
    }
}