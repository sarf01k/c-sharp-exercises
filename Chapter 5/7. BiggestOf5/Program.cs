namespace BiggestOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers:");

            float biggest = 0;

            for (int i = 0; i < 5; i++)
            {
                float num = float.Parse(Console.ReadLine());

                if (num > 5)
                {
                    biggest = num;
                }
            }

            Console.WriteLine("Greatest: {0}", biggest);
        }
    }
}