﻿namespace DigitToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit (0 - 9): ");
            byte digit = byte.Parse(Console.ReadLine());

            string word;

            switch (digit)
            {
                case 0:
                    word = "zero";
                    break;
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
                default:
                    word = "a digit NOT between 0 to 9";
                    break;
            }

            Console.WriteLine("You entered {0}", word);
        }
    }
}