namespace Exercise4
{
    class Program{
        static void Main(string[] args)
        {
            int num = 2;

            bool bit3 = (num & 4) != 0;

            if (bit3)
                Console.WriteLine("Third bit is 1");
            else
                Console.WriteLine("Third bit is not 1");
        }
    }
}