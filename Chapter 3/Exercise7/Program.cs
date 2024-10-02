namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Weight on Earth: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Weight on the moon is {0}", 0.17 * earthWeight);
        }
    }
}