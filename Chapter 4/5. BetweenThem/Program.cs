namespace BetweenThem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = num1; i <= num2; i++)
            {
                if (i % 5 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers between {1} and {2} divisible by 5", count, num1, num2);
        }
    }
}