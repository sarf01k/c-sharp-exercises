namespace IncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] elements = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

            byte[] sequenceLengths = new byte[elements.Length];

            byte start = elements[0];
            byte len = 1;
            byte bestLen = len;

            // for (int i = 0; i < elements.Length; i++)
            // {
            //     len = 1;
            //     for (int j = i + 1; j < elements.Length; j++)
            //     {
            //         if (elements[j] > elements[i])
            //         {
            //             len++;
            //         }
            //     }
            //     sequenceLengths[i] = len;
            //     Console.WriteLine(sequenceLengths[i]);
            // }

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length                                                                                                                                      ; j++)
                {
                    
                }
            }

            byte longest = sequenceLengths.ToList().Max();
            Array.IndexOf(sequenceLengths, longest);
            Console.WriteLine(longest);
        }
    }
}