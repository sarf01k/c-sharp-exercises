namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 3;
            sbyte y = 4;

            bool inCircle = x*x + y*y <= 25;
            bool notInRectangle = (x < -1 && x > 5) || (y < 1 && y > 5);
            if (inCircle && notInRectangle)
                Console.WriteLine("The point is in the circle & out of the rectangle");
            else
                Console.WriteLine("The point is not in the circle & out of the rectangle");
        }
    }
}