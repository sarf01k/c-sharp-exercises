namespace TwentyElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[20];

            Console.Write("Elements: ");

            for (int i = 0; i < 20; i++)
            {
                elements[i] = i * 5;
                if (i == 19)
                    Console.Write("{0}", elements[i]);
                else
                Console.Write("{0}, ", elements[i]);
            }
        }
    }
}