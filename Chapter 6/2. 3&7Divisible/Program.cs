﻿namespace DivisibleBy3and7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNumbers divisible by 3 & 7:");

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}