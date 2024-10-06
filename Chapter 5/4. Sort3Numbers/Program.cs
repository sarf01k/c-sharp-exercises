namespace BiggestOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());

            float temp;

            if (num1 < num2)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;

                if (num2 < num3)
                {
                    temp = num3;
                    num3 = num2;
                    num2 = temp;

                    if (num1 < num2)
                    {
                        temp = num2;
                        num2 = num1;
                        num1 = temp;
                    }  
                }   
            }

            Console.WriteLine("Descending order: {0}, {1}, {2}", num1 ,num2, num3);
        }
    }
}