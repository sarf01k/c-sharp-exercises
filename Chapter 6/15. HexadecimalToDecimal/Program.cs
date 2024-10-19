namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number (in caps): ");
            string hexa = Console.ReadLine();

            int toDecimal = 0;

            for (int i = 0, power = hexa.Length - 1; i < hexa.Length && power >= 0; i++, power--)
            {
                switch (hexa[i])
                {
                    case 'A':
                        toDecimal += 10 * (int)Math.Pow(16, power);
                        break;
                    case 'B':
                        toDecimal += 11 * (int)Math.Pow(16, power);
                        break;
                    case 'C':
                        toDecimal += 12 * (int)Math.Pow(16, power);
                        break;
                    case 'D':
                        toDecimal += 13 * (int)Math.Pow(16, power);
                        break;
                    case 'E':
                        toDecimal += 14 * (int)Math.Pow(16, power);
                        break;
                    case 'F':
                        toDecimal += 15 * (int)Math.Pow(16, power);
                        break;
                    default:
                        toDecimal += byte.Parse(hexa[i].ToString()) * (int)Math.Pow(16, power);
                        break;
                }
            }
            
            Console.WriteLine("To decimal: {0}", toDecimal);
        }
    }
}