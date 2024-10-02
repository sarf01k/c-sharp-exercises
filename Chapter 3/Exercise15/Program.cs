namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            uint number = uint.Parse(Console.ReadLine());

            uint bit3 = (number >> 3) & 1;
            uint bit24 = (number >> 24) & 1;
            number = (uint) (number & (~(1 << 24)) | (bit3 << 24));
            number = (uint) (number & (~(1 << 3)) | (bit24 << 3));

            uint bit4 = (number >> 4) & 1;
            uint bit25 = (number >> 25) & 1;
            number = (uint)(number & (~(1 << 25)) | (bit4 << 25));
            number = (uint)(number & (~(1 << 4)) | (bit25 << 4));

            uint bit5 = (number >> 5) & 1;
            uint bit26 = (number >> 26) & 1;
            number = (uint)(number & (~(1 << 26)) | (bit5 << 26));
            number = (uint)(number & (~(1 << 5)) | (bit26 << 5));

            Console.WriteLine("New number: " + number);
        }
    }
}