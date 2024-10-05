namespace GreatestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int greatest = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.WriteLine("Enter integer {0} of 5: ", (i + 1));
                } while (!int.TryParse(Console.ReadLine(), out numbers[i]));

                if (numbers[i] > greatest)
                {
                    greatest = numbers[i];
                }
            }

            Console.WriteLine("\nGreatest: {0}", greatest);
        }
    }
}