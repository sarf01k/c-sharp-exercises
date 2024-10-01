namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 4-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            int sum = (a + b + c + d);
            string reversed = $"{a}{b}{c}{d}";
            string lastToFirst = $"{a}{d}{c}{b}";
            string secondToThird = $"{d}{b}{c}{a}";

            Console.WriteLine("Sum: {0}\nReversed: {1}\nLast to first: {2}\nSecond to third: {3}", sum, reversed, lastToFirst, secondToThird);
        }
    }
}