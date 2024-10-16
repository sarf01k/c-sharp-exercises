namespace PrintCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            string[] suits = {"Heart", "Club", "Diamond", "Spade"};

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    switch (suits[j])
                    {
                        case "J":
                            continue;
                        default:
                            Console.WriteLine("{0} of {1}s", numbers[i], suits[j]);
                            break;
                    }
                }
            }
        }
    }
}