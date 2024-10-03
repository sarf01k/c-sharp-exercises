namespace CirclePArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius: ");
            int r = int.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("Perimeter: {0:F2}\nArea: {1:F2}", perimeter, area);
        }
    }
}