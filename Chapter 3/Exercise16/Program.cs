namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            uint number = uint.Parse(Console.ReadLine());

            uint bitI;
            uint bitIPlus15;

            for (int i = 1; i <= 16; i++)
            {
                bitI = (number >> i) & 1;
                bitIPlus15 = (number >> (i + 16)) & 1;
                number = (uint)(number & (~(1 << (i + 16))) | (bitI << (i + 16)));
                number = (uint)(number & (~(1 << i)) | (bitIPlus15 << i));
            }

            Console.WriteLine("New number : " + number);
        }
    }
}