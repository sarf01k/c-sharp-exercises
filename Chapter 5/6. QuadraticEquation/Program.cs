namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a, b & c:");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float d = (float)(Math.Pow(b, 2) - (4 * a * c));

            if (d == 0)
            {
                float x = -b / (2 * a);

                Console.WriteLine("One real root:", x);
            }
            else if (d > 0)
            {
                float x1 = (float)(-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));
                float x2 = (float)(-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));

                Console.WriteLine("Two distinct real roots: {0}, {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("No real roots.");
            }
        }
    }
}