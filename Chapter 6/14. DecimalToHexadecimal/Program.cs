namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int fromDecimal = int.Parse(Console.ReadLine());

            Console.WriteLine("To hexadecimal: {0:X}", fromDecimal);
        }
    }
}