namespace MostFrequent
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] elements = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4, 4, 4, 4, 4, 4 };

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("{0} ", elements[i]);
            }

            byte mostFreq = byte.MinValue;
            byte len = 1;
            byte bestLen = len;

            for (int i = 0; i < elements.Length; i++)
            {
                len = 1;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[j] == elements[i])
                        len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        mostFreq = elements[i];
                    }   
                }
            }

            Console.WriteLine("\nMost frequent: {0}({1} times)", mostFreq, bestLen);
        }
    }
}