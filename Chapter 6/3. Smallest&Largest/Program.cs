namespace SmallestLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers? ");
            int number = int.Parse(Console.ReadLine());

            int smallest = int.MaxValue;
            int largest = int.MinValue;

            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter number {0}: ", i);
                int current = int.Parse(Console.ReadLine());

                if (current < smallest)
                {
                    smallest = current;
                }

                if (current > largest)
                {
                    largest = current;
                }
            }

            Console.WriteLine("\nSmallest: {0}\nLargest: {1}", smallest, largest);
        }
    }
}