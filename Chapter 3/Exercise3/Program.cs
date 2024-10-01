namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 98765;
            double temp = (number/100) % 10;

            if (temp == 7)
                Console.WriteLine("3rd digit is 7");
            else
                Console.WriteLine("3rd digit is not 7");
        }
    }
}