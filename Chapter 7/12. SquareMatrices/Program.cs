int init = 1;

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,]
matrixA = new int[n, n],
matrixB = new int[n, n],
matrixC = new int[n, n],
matrixD = new int[n, n];

// // A
// for (int j = 0; j < n; j++)
// {
//     for (int k = 0; k < n; k++)
//     {
//         matrixA[k, j] = init;
//         init++;
//     }
// }
// PrintMatrix(matrixA, n);

// // B
// init = 1;
// for (int i = 0; i < n; i++)
// {
//     if (i % 2 == 0)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrixB[j, i] = init;
//             init++;
//         }
//     }
//     else
//     {
//         for (int k = n - 1; k >= 0; k--)
//         {
//             matrixB[k, i] = init;
//             init++;
//         }
//     }
// }
// PrintMatrix(matrixB, n);

// C
// int positionX = 0;
// int positionY = n - 1;

// for (int i = 1; i <= n * n; i++)
// {
//     matrixC[positionY, positionX] = i;

//     if (positionX == n - 1)
//     {
//         positionX = (positionX - positionY) + 1;
//         positionY = 0;
//     }
//     else if (positionY == n - 1)
//     {
//         if (positionX != 0)
//         {
//             positionY -= (positionX + 1);

//             if (positionX == n - 1)
//             {
//                 positionX -= 2; 
//             }
//             else if (positionX == n/2)
//             {
//                 positionX -= 2;
//             }
//             else
//             {
//                 positionX -= 1;
//             }
//         }
//         else
//         {
//             positionY--;
//         }
//     }
//     else
//     {
//         positionY++;
//         positionX++;
//     }
// }
// PrintMatrix(matrixC, n);

// D
for (int i = 1; i <= n * n; i++)
{
    
}

// ************
static void PrintMatrix(int[,] matrix, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0}".PadRight(MaxWidth(matrix) - matrix[i, j].ToString().Length + 2), matrix[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

static int MaxWidth(int[,] matrix)
{
    int maxWidth = matrix.Cast<int>().Max(num => num.ToString().Length);
    return maxWidth + 2;
}