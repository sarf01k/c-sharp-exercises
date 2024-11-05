namespace CertainSum
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] numbers = { 4, 3, 1, 4, 2, 5, 8 };

            Console.Write("Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.Write("\n\nEnter a number: ");
            byte target;
            byte.TryParse(Console.ReadLine(), out target);

            byte sum;
            byte len = 1;
            byte startIndx;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i];
                startIndx = (byte)i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (sum == target)
                    {
                        Console.Write("{0} -> ", target);
                        for (int k = startIndx; k < startIndx + len; k++)
                        {
                            Console.Write("{0}", numbers[k]);
                            break;
                        }
                    }
                    else if (sum > target)
                    {
                        Console.WriteLine("\nNo sequence.");
                        break;
                    }
                    else
                    {
                        sum += numbers[j];
                        len++;
                    }
                }
            }
        }
    }
}