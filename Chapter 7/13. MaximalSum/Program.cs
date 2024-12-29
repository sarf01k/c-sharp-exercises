int n;
int m;

do
{
    Console.Write("Enter n: ");
    n = int.Parse(Console.ReadLine());

    Console.Write("Enter m: ");
    m = int.Parse(Console.ReadLine());

    if (n <= 3 || m <= 3)
        Console.WriteLine("'n' and 'm' must be > 3\n");
} while (n <= 3 || m <= 3);

int[,] matrix = new int[n, m];

Random random = new();

// matrix is filled randomly
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = random.Next(1, 10);        
    }
}
PrintMatrix(matrix, n, m);

// main thing
int bestSum = 0;
int bestCol = 0;
int bestRow = 0;

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
            + matrix[row + 2, col] + matrix[row + 1, col + 1] + matrix[row + 2, col + 2];

        if (sum > bestSum)
        {
            bestSum = sum;
            bestCol = col;
            bestRow = row;
        }
    }
}

Console.WriteLine("Platform:");
Console.WriteLine("  {0}   {1}   {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
Console.WriteLine("  {0}   {1}   {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
Console.WriteLine("  {0}   {1}   {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);

Console.WriteLine($"\nBest sum: {bestSum}");

Console.ReadLine();

///
static void PrintMatrix(int[,] matrix, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{0}".PadRight(6), matrix[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}
///