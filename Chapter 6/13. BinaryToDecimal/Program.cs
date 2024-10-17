namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an 8-bit binary number in the format xxxxxxxx: ");
            decimal binary = decimal.Parse(Console.ReadLine());

            int toDecimal = 0;
            for (int i = 0; i < 8; i++)
            {
                toDecimal += (int)((double)binary % 10 * Math.Pow(2, i));
                binary /= 10;

                if (binary == 1)
                {
                    break;
                }
            }

            Console.WriteLine("To decimal: {0}", toDecimal);
        }
    }
}