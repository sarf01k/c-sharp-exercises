namespace ConsecutiveEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] elements = { 1, 2, 2, 3, 2, 2, 2, 1, 1, 1, 1 };

            byte start = elements[0];
            byte len = 1;
            byte bestStart = start;
            byte bestLen = len;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == start)
                {
                    len++;
                }
                else
                {
                    len = 1;
                    if (i != elements.Length - 1)
                        start = elements[i];
                }

                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }

            Console.Write("Longest sequence is: { ");
            for (int i = 0; i < bestLen; i++)
            {
                if (i == bestLen - 1)
                    Console.Write("{0} ", bestStart);
                else
                    Console.Write("{0}, ", bestStart);
            }
            Console.Write("}");
        }
    }
}