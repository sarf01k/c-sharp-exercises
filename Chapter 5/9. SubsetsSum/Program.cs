namespace SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {3, -2, 1, 1, 8};

            Console.Write("From the numbers: {");
            foreach (int number in numbers)
            {
                Console.Write(number + ",");
            }
            Console.Write("}\n");
            Console.WriteLine("Subsets that add up to 0 are:");

            if (numbers[0] + numbers[1] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[0], numbers[1]); 
            }
            else if (numbers[0] + numbers[1] + numbers[2]== 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
            }
            else if (numbers[0] + numbers[1] + numbers[3]== 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[1], numbers[3]);
            }
            else if (numbers[0] + numbers[1] + numbers[4]== 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[1], numbers[4]);
            }
            else if (numbers[0] + numbers[1] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", numbers[0], numbers[1], numbers[2], numbers[3]);
            }
            else if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            }
            else if (numbers[0] + numbers[1] + numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", numbers[0], numbers[1], numbers[2], numbers[4]);
            }
            else if (numbers[0] + numbers[2] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[0], numbers[2]);
            }
            else if (numbers[0] + numbers[2] + numbers[3]== 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[2], numbers[3]);
            }
            else if (numbers[0] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", numbers[0], numbers[2], numbers[3], numbers[4]);
            }
            else if (numbers[0] + numbers[2] + numbers[4]== 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[2], numbers[4]);
            }
            else if (numbers[0] + numbers[3] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[0], numbers[3]);
            }
            else if (numbers[0] + numbers[3] + numbers[4]== 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[0], numbers[3], numbers[4]);
            }
            else if (numbers[0] + numbers[4] == 0) 
            {
                Console.WriteLine("{0}, {1}", numbers[0], numbers[4]);
            }
            else if (numbers[1] + numbers[2] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[1], numbers[2]);
            }
            else if (numbers[1] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[1], numbers[2], numbers[3]);
            }
            else if (numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", numbers[1], numbers[2], numbers[3], numbers[4]);
            }
            else if (numbers[1] + numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[1], numbers[2], numbers[4]);
            }
            else if (numbers[1] + numbers[3] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[1], numbers[3]);
            }
            else if (numbers[1] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[1], numbers[3], numbers[4]);
            }
            else if (numbers[1] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[1], numbers[4]);
            }
            else if (numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[2], numbers[3]);
            }
            else if (numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[2], numbers[3], numbers[4]);
            }
            else if (numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[2], numbers[4]);
            }
            else if (numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[3], numbers[4]);
            }
            else
            {
                Console.WriteLine("No subsets add up to 0.");
            }
        }
    }
}