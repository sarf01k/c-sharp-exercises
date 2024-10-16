namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            decimal previous = 0;
            decimal current = 1;

            Console.Write("{0} {1} ", previous, current);

            for (int i = 1; i <= number; i++)
            {
                current += previous;
                Console.Write("{0} ", current);
                previous = current - previous;
            }
        }
    }
}