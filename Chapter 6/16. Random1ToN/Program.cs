namespace Random1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            numbers[0] = 1;

            Console.Write("Enter a number > 1: ");
            int number = int.Parse(Console.ReadLine());

            // for (int i = 2; i <= 2; i++)
            // {
                numbers.Append(2);
                // Console.WriteLine(numbers[i]);
            // }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}