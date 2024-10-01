namespace Exercise12
{
    class Program{
        static void Main(string[] args)
        {
            int v = 5;
            int p = 1;

            bool bit = ((v >> (p)) & 1) == 1;

            if (bit)
                Console.WriteLine("The bit at position {0} is 1", p);
            else
                Console.WriteLine("The bit at position {0} is not 1", p);
        }
    }
}