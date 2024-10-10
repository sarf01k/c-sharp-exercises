namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Score: ");
            byte score = byte.Parse(Console.ReadLine());

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Final score: {0}", score * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Final score: {0}", score * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Final score: {0}", score * 100);
                    break;
                default:
                    Console.WriteLine("Score must be in the range 1...9");
                    break;
            }
        }
    }
}