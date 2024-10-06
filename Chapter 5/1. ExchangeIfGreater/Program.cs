namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int temp;

            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("\nFirst number: {0}\nSecond number: {1}", num1, num2);
        }
    }
}