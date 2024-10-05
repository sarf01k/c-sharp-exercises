namespace SequenceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            float currentSum = 0;
            float newSum = 1;
            float fraction = 2F;

            while (Math.Abs(newSum - currentSum) >= 0.001)
            {
                currentSum = newSum;

                if (fraction % 2 == 0)
                {
                    newSum = currentSum + (1/fraction);
                }
                else
                {
                    newSum = currentSum - (1/fraction);
                }
                fraction++;
            }

            Console.WriteLine("Result: {0:F3}", newSum);
        }
    }
}