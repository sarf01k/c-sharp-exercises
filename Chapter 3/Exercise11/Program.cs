namespace Exercise11
{
    class Program{
        static void Main(string[] args)
        {
            int num = 35;
            int position = 5;

            bool bit = ((num >> (position)) & 1) == 1;

            if (bit)
                Console.WriteLine("The bit at position {0} is 1", position);
            else
                Console.WriteLine("The bit at position {0} is 0", position);
        }
    }
}