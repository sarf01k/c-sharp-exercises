namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            byte n = byte.Parse(Console.ReadLine());

            byte[,] matrix = new byte[n, n];

            FillMatrix(matrix, n);
            PrintMatrix(matrix, n);
        }

        private static void FillMatrix(byte[,] matrix, byte n)
        {
            // starting position
            byte positionY = 0;
            byte positionX = 0;

            byte direction = 0;
            byte stepCount = 1;
            byte stepPosition = 0;
            byte stepChange = 0;

            for (byte i = 1; i <= n * n; i++)
            {
                matrix[positionY, positionX] = i;

                if (stepPosition < stepCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepCount++;
                    }
                    stepChange = (byte)((stepChange + 1) % 3);
                    direction = (byte)((direction + 1) % 1);
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