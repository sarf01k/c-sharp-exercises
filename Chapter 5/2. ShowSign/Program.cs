namespace ShowSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeNumbersCount = 0;

            Console.WriteLine("Enter 3 integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < 0)
            {
                negativeNumbersCount++;
            }
            if (num2 < 0)
            {
                negativeNumbersCount++;
            }
            if (num3 < 0)
            {
                negativeNumbersCount++;
            }

            if (negativeNumbersCount == 0)
            {
                Console.WriteLine("Product is 0. No sign.");
            }
            
            if (negativeNumbersCount == 2)
            {
                Console.WriteLine("Sign: +");
            }

            if (negativeNumbersCount % 2 != 0)
            {
                Console.WriteLine("Sign: -");
            }
        }
    }
}