namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 3;
            byte y = 4;

            if (x*x + y*y <= 25)
                Console.WriteLine("The point ({0}, {1}) is in the circle", x, y);
            else
                Console.WriteLine("The point ({0}, {1}) is not in the circle", x, y);
        }
    }
}