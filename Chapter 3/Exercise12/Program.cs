namespace Exercise12
{
    class Program{
        static void Main(string[] args)
        {
            int v = 5;
            int p = 1;

            bool bit = ((v >> p) & 1) == 1;

            Console.WriteLine(bit);
        }
    }
}