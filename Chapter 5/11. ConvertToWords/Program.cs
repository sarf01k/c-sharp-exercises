namespace ConvertToWords
{
    class Program
    {
        private static string ToWords(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                default:
                    return "number must be between [0...999]";
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number [0...999]: ");
            int number = int.Parse(Console.ReadLine());
            string words;

            if (number <= 9)
            {
                words = ToWords(number);
            }
            else
            {
                if (number >= 10)
                {
                    switch (number / 10)
                    {
                        case 1:
                            words = "Ten";
                            break;
                        case 2:
                            words = "Twenty";
                            break;
                        case 3:
                            words = "Thirty";
                            break;
                        case 4:
                            words = "Forty";
                            break;
                        case 5:
                            words = "Fifty";
                            break;
                        case 6:
                            words = "Sixty";
                            break;
                        case 7:
                            words = "Seventy";
                            break;
                        case 8:
                            words = "Eighty";
                            break;
                        case 9:
                            words = "Ninety";
                            break;
                        default:
                            words = "Number must be between [0...999]";
                            break;
                    }

                    switch (number % 10)
                    {
                        case 1:
                            words += " one";
                            break;
                        case 3 :
                            words = "Thirty";
                            break;
                        case 4:
                            words = "Forty";
                            break;
                        case 5:
                            words = "Fifty";
                            break;
                        case 6:
                            words = "Sixty";
                            break;
                        case 7:
                            words = "Seventy";
                            break;
                        case 8:
                            words = "Eighty";
                            break;
                        case 9:
                            words = "Ninety";
                            break;
                        default:
                            words = "Number must be between [0...999]";
                            break;
                    }
                }

                switch (number / 100)
                {
                    case 1:
                        words = "Hundred";
                        break;
                    case 2:
                        words = "Two hundred";
                        break;
                    case 3:
                        words = "Three hundred";
                        break;
                    case 4:
                        words = "Four hundred";
                        break;
                    case 5:
                        words = "Five hundred";
                        break;
                    case 6:
                        words = "Six hundred";
                        break;
                    case 7:
                        words = "Seven hundred";
                        break;
                    case 8:
                        words = "Eight hundred";
                        break;
                    case 9:
                        words = "Nine hundred";
                        break;
                    default:
                        words = "Number must be between [0...999]";
                        break;
                }
            }
        }
    }
}