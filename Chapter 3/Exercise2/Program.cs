namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 35;
            bool isDivisible = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine(isDivisible);
        }
    }
}