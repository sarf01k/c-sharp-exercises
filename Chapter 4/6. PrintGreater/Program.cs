namespace PrintGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter 2 integers:");
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("{0} is bigger.", Math.Max(num1, num2));
        }
    }
}