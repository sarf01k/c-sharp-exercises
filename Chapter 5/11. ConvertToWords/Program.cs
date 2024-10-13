namespace ConvertToWords
{
    class Program
    {
        private static string Digit(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Number must be between [0...999]";
            }
        }

        private static string TeenDigit(int number)
        {
            switch (number % 10)
            {
                case 0:
                    return "eleven";
                case 1:
                    return "eleven";
                case 2:
                    return "twelve";
                case 3:
                    return "thirteen";
                case 4:
                    return "fourteen";
                case 5:
                    return "fifteen";
                case 6:
                    return "sixteen";
                case 7:
                    return "seventeen";
                case 8:
                    return "eighteen";
                case 9:
                    return "nineteen";
                default:
                    return "Number must be between [0...999]";
            }
        }

        private static string DoubleDigit(int number)
        {
            switch (number)
            {
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eighty";
                case 9:
                    return "ninety";
                default:
                    return "Number must be between [0...999]";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number [0...999]: ");
            int number = int.Parse(Console.ReadLine());
            string words = "";

            if (number >= 0 && number <= 999)
            {
                if (number == 0)
                    words = "Zero";

                if (number >= 100)
                {
                    words = Digit(number / 100);
                    words += " hundred";

                    if ((number % 100) / 10 >= 2 && (number % 100) / 10 <= 9)
                    {
                        words += " and " + DoubleDigit((number % 100) / 10);

                        if ((number % 10) >= 1 && (number % 10) <= 9)
                        {
                            words += " " + Digit(number % 10);
                        }
                    }
                    else if (number % 100 / 10 == 0)
                    {
                        words += " and " + Digit(number % 10);
                    }
                    else
                    {
                        words += " and " + TeenDigit((number % 100) % 10);
                    }
                }

                if (number >= 20 && number <= 99)
                {
                    words += DoubleDigit(number / 10);

                    if (number % 10 > 0)
                    {
                        words += " " + Digit(number % 10);
                    }
                }

                if (number < 20)
                {
                    if (number / 10 > 0)
                    {
                        words = TeenDigit(number);
                    }
                    else
                    {
                        words = Digit(number);
                    }
                }
            }
            else
            {
                words = "Number must be between [0...999]";
            }

            Console.WriteLine(words.Substring(0, 1).ToUpper() + words.Substring(1));
        }
    }
}