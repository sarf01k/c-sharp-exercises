namespace Exerxise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 102;
            for (int i = 2; i < counter; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("-");
                }
                Console.Write($"{i} ");
            }
        }
    }
}