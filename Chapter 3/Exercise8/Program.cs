namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 3;
            byte y = 4;

            if (x*x + y*y <= 25)
                Console.WriteLine("The point is in the circle");
            else
                Console.WriteLine("The point is not in the circle");
        }
    }
}