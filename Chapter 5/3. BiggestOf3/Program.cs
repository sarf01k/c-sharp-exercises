namespace BiggestOf3
{
    class Prgoram
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int biggest;

            if (num2 > num1 || num3 > num1)
            {
                if (num2 > num3)
                {
                    biggest = num2;
                }
                else
                {
                    biggest = num3;
                }
            }
            else
            {
                biggest = num1;
            }

            Console.WriteLine("Biggest: {0}", biggest);
        }
    }
}