namespace InTheRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the integer: ");
            int integer = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPrinting [1...{0}]", integer);

            for (int i = 1; i <= integer; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}