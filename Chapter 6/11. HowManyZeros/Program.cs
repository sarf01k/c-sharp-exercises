namespace HowManyZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            byte number = byte.Parse(Console.ReadLine());

            decimal factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.Write("The factorial of {0} is {1}. ", number, factorial); 

            byte zerosCounter = 0;

            for (int i = 0; i < Math.Sqrt(number); i++)
            {
                if (factorial % 10 == 0)
                {
                    zerosCounter++;
                    factorial = factorial/10;
                }
                else
                    break;
            }

            Console.WriteLine("It has {0} zeros at the end.", zerosCounter);
        }
    }
}