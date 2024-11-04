namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] elements = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("{0} ", elements[i]);
            }

            byte temp, smallest;
            for (int i = 0; i < elements.Length - 1; i++)
            {
                smallest = (byte)i;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[j] < elements[smallest])
                        smallest = (byte)j;
                }

                temp = elements[smallest];
                elements[smallest] = elements[i];
                elements[i] = temp;
            }

            Console.WriteLine("\nSorted:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("{0} ", elements[i]);
            }
        }
    }
}