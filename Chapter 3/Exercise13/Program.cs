namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int v = 0;
            int p = 5;
            int newN = n & (~(1 << p));

            Console.WriteLine("Changing the bit at position {0} to {1} in the number {2}, the number then becomes {3}", p, v, n, newN);            
        }
    }
}