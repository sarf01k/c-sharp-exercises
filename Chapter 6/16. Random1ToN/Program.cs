namespace Random1ToN
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number > 1: ");
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            for (int i = 1; i <= number; i++)
            {
                numbers[i - 1] = i;
            }

            Random rnd = new();
            int random = int.MinValue;
            var numbersList = numbers.ToList();

            for (int i = 0; i < number; i++)
            {
                random = rnd.Next(numbersList.Count);
                Console.Write("{0} ", numbersList[random]);
                numbersList.Remove(numbersList[random]);
            }
        }
    }
}