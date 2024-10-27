namespace Lexicography
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars1 = { 'a', 'b', 'd', 'e'};
            char[] chars2 = { 'a', 'b', 'c', 'f'};

            byte a;
            byte b;

            for (int i = 0, j = 0; i < chars1.Length && j < chars2.Length; i++, j++)
            {
                a = (byte)chars1[i];
                b = (byte)chars2[i];

                if (chars1.Length > chars2.Length)
                {
                    Console.WriteLine("The second array comes first.");
                    return;
                }
                else if (chars1.Length < chars2.Length)
                {
                    Console.WriteLine("The first array comes first.");
                    return;
                }
                else
                {
                    if (a < b || a == 0)
                    {
                        Console.WriteLine("The first array comes first.");
                        return;
                    }
                    else if (a > b)
                    {
                        Console.WriteLine("The second array comes first.");
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine("The arrays are equal.");
        }
    }
}