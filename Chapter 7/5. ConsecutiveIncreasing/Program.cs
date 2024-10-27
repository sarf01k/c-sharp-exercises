namespace ConsecutiveIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] elements = { 1, 3, 2, 3, 4, 8, 9, 10, 11 };

            byte start = elements[0];
            byte len = 1;
            byte bestStart = start;
            byte bestLen = len;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == start + 1)
                {
                    len++;
                }
                else {
                    len = 1;
                }

                start = elements[i];

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }

            Console.Write("Longest increasing sequence is: { ");
            for (int i = (bestStart - bestLen) + 1; i <= bestStart; i++)
            {
                if (i == bestStart)
                    Console.Write("{0} ", i);
                else
                    Console.Write("{0}, ", i);
            }
            Console.Write("}");
        }
    }
}