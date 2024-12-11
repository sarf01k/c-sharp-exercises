namespace CertainSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };

            Console.Write("Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.Write("\n\nEnter a number: ");
            int target;
            int.TryParse(Console.ReadLine(), out target);

            int sum = 0;
            int startIndx = int.MinValue;
            int count = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                startIndx = i;
                sum = numbers[startIndx];
                count = startIndx + 1;

                while (sum < target && count < numbers.Length)
                {
                    sum += numbers[count];
                    count++;

                    if (sum == target)
                    {
                        Console.Write($"{target} -> ( ");
                        for (int j = startIndx; j < count; j++)
                        {
                            if (j == count - 1)
                                Console.Write($"{numbers[j]}");
                            else
                                Console.Write($"{numbers[j]}, ");
                        }
                        Console.Write(" )");
                        return;
                    }
                }
            }

            Console.WriteLine($"No numbers add up to {target}");
        }
    }
}