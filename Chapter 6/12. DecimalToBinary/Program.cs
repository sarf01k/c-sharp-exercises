namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            byte inDecimal = byte.Parse(Console.ReadLine());

            string inBinary = "";

            byte quotient = byte.MinValue;
            byte remainder = byte.MinValue;
            do
            {
                quotient = (byte)(inDecimal / 2);
                remainder = (byte)(inDecimal % 2);
                inDecimal = quotient;
                inBinary += remainder;
            } while (quotient != 0);

            char[] reverse = inBinary.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine("To binary: {0}", String.Concat(reverse).PadLeft(8, '0').Insert(4, " "));
        }
    }
}