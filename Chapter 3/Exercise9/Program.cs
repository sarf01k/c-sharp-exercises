namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 2;
            sbyte y = 4;

            bool inCircle = x*x + y*y <= 25;
            bool outsideRectangle = (x < -1 || x > 5) || (y < 1 || y > 5);

            Console.WriteLine("The point is ({0}, {1}) is "+ (inCircle ? "inside" : "outside") +" the circle & " + (outsideRectangle ? "outside" : "inside") + " the rectangle", x, y);
        }
    }
}