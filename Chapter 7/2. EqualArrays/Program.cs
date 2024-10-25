namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of array 1: ");
            byte arraySize = byte.Parse(Console.ReadLine());
            string[] array1 = new string[arraySize];
            InputElements(array1, arraySize);

            Console.Write("Length of array 2: ");
            arraySize = byte.Parse(Console.ReadLine());
            string[] array2 = new string[arraySize];
            InputElements(array2, arraySize);

            if (array1.Length != array2.Length)
            {
                Console.WriteLine("\nThe arrays are not equal.");
                return;
            }

            for (int i = 0; i < arraySize; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("\nThe arrays are not equal.");
                    return;
                }
            }

            Console.WriteLine("\nThe arrays are equal.");
        }

        private static void InputElements(string[] array, byte size)
        {
            Console.WriteLine("Input the elements:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }
        }
    }
}