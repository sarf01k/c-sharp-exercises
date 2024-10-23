namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            byte n = byte.Parse(Console.ReadLine());

            byte[,] matrix = new byte[n, n];
        }

        private static void FillMatrix(byte[,] matrix, byte n)
        {
            // starting position
            byte positionY = 0;
            byte positionX = 0;

            byte direction = 0;
            byte stepCount = 3;
            byte stepPosition = 0;

            for (byte i = 1; i <= n; i++)
            {
                matrix[positionY, positionX] = i;

                if (stepPosition < stepCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                }

                switch (direction)
                {
                    case 0:
                        positionX++;
                        break;
                    case 1:
                        positionY++;
                        break;
                    case 2:
                        positionX--;
                        break;
                    case 3:
                        positionY--;
                        break;
                }
            }
        }

        private static void PrintMatrix(byte[,] matrix, byte n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }
            }
        }
    }
}