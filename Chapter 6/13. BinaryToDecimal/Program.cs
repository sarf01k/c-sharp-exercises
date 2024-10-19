using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            Int128 binary = Int128.Parse(Console.ReadLine());

            Int128 toDecimal = 0;
            int power = 0;

            do
            {
                toDecimal += binary % 10 * (int)Math.Pow(2, power);
                binary /= 10;
                power++;
            } while (binary >= 1);

            Console.WriteLine("To decimal: {0}", toDecimal);
        }
    }
}