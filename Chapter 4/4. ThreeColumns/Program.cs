namespace ThreeColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45645;
            int num2 = 34;
            int num3 = 5;

            Console.WriteLine("{0,-10:X}{1,-10:0.00}{2,-10:-0.00}", num1, num2, num3);
        }
    }
}