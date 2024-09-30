namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 4;

            Console.WriteLine($"Before:\nnum1 = {num1}\nnum2 = {num2}");

            int temp = num2;
            num2 = num1;
            num1 = temp;

            Console.WriteLine($"After:\nnum1 = {num1}\nnum2 = {num2}");
        }
    }
}