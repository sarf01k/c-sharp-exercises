namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = Double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = Double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);
            double area = length * width;
            Console.WriteLine("Rectangle:\n\tPerimeter: {0}\n\tArea is {1}", perimeter, area);
        }
    }
}