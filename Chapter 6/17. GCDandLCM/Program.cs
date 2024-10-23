namespace GCDandLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int product = Math.Abs(num1 * num2);

            do
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            } while (num1 != num2);

            Console.WriteLine("GCD is {0}", num1);
            Console.WriteLine("LCM is {0}", product/num1);
        }
    }
}