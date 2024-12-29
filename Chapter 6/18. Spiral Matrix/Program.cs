namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            FillMatrix(matrix, n);
            PrintMatrix(matrix, n);
        }

        private static void FillMatrix(int[,] matrix, int n)
        {
            // starting position
            int positionY = 0;
            int positionX = 0;

            int direction = 0;
            int stepCount = 3 ;
            int performedSteps = 0;
            int stepChange = 0;

            for (int i = 1; i <= n * n; i++)
            {
                matrix[positionY, positionX] = i;

                if (performedSteps < stepCount)
                {
                    performedSteps++;
                }
                else
                {
                    performedSteps = 1;
                    if (stepChange == 1)
                    {
                        stepCount--;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
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

        private static void PrintMatrix(int[,] matrix, int n)
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