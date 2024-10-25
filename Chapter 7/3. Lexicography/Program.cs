namespace Lexicography
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars1 = { 'a', 'b',};
            char[] chars2 = { 'a', 'b',};
            
            const byte a = (byte)'a';
            byte b = (byte)'b';

            Console.WriteLine("{0} {1}", a, b);

            switch (a)
            {
                case > b:
                    Console.WriteLine("More");
                    break;
                case < b:
                    Console.WriteLine("Less");
                    break;
                default:
                    Console.WriteLine("Equal");
                    break;
            }
        }
    }
}