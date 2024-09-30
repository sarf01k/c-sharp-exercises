namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 4.53365f;
            float num2 = 2.53355f;
            float accuracy = 0.000001f;

            if (Math.Abs(num1 - num2) >= accuracy)
                Console.WriteLine("not equal");
            else
                Console.WriteLine("equal");
        }
    }
}