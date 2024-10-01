namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Weight on Earth: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            double moonWeight = 0.17 * earthWeight;

            Console.WriteLine("Weight on the moon is {0}", moonWeight);
        }
    }
}