namespace UsersChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick one:\n0. int\n1. double\n2. string\n");
            string choice = Console.ReadLine();

            dynamic input;

            switch (choice)
            {
                case "0":
                    Console.Write("Enter an integer: ");
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", input + 1);
                    break;
                case "1":
                    Console.Write("Enter a double: ");
                    input = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", input + 1);
                    break;
                case "2":
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    Console.WriteLine("Result: {0}", input + "*");
                    break;
                default:
                    Console.WriteLine("Enter 0, 1 or 2.");
                    break;
            }
        }
    }
}