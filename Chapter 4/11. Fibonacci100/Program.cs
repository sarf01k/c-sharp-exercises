namespace Fibonacci100
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal previous = 0;
            decimal actual = 1;
            decimal add = 0;

            Console.WriteLine(previous);
            Console.WriteLine(actual);

            for (int i = 2; i <= 98; i++)
            {
                add = previous + actual;
                Console.WriteLine(add);
                previous = actual;
                actual = add;                
            }
        }
    }
}