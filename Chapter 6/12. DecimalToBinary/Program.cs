namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            long inDecimal = long.Parse(Console.ReadLine());

            string inBinary = "";

            long quotient = long.MinValue;
            long remainder = long.MinValue;
            do
            {
                quotient = (long)(inDecimal / 2);
                remainder = (long)(inDecimal % 2);
                inDecimal = quotient;
                inBinary += remainder;
            } while (quotient != 0);

            char[] inReverse = inBinary.ToCharArray();
            Array.Reverse(inReverse);
            Console.WriteLine("To binary: {0}", String.Concat(inReverse));
        }
    }
}