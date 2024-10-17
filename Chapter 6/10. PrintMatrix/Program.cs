namespace PrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer < 20: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("\n");
                for (int j = i; j <= i + (num - 1); j++)
                {
                    if (j >= 10)
                        Console.Write($"{j} ");
                    else
                        Console.Write($"{j}  ");
                }
            }
        }
    }
}