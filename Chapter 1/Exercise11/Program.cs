namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats's your age?");
            int age = int.Parse(Console.ReadLine());

            DateTime birthday = DateTime.Now.AddYears(10);
            Console.WriteLine($"By {birthday}, you will be {age + 10} years old.");
        }
    }
}