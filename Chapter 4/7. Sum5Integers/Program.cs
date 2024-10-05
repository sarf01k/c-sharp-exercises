namespace Sum5Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSum: {0}", (num1 + num2 + num3 + num4 + num5));
        }
    }
}