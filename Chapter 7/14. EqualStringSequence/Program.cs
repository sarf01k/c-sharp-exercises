string[,] matrix = {
    { "ha", "fifi", "ho", "hi" },
    { "fo", "ha", "hi", "xx" },
    { "xxx", "ho", "ha", "xx" }
};

string currentString, longestString = "";
int maxFrequency = 1;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        currentString = matrix[row, col];

        int horizontalFreq = CheckHorizontal(col, matrix, row, currentString);
        int verticalFreq = CheckVertical(col, matrix, row, currentString);
        int diagonalFreq = CheckDiagonal(col, matrix, row, currentString);
        
        int frequency = MaxFrequency(horizontalFreq, verticalFreq, diagonalFreq);

        if (frequency > maxFrequency)
        {
            maxFrequency = frequency;
            longestString = currentString;
        }
    }
}

Console.Write("Longest sequence: ");
for (int i = 0; i < maxFrequency; i++)
{
    if (i == maxFrequency - 1)
        Console.Write($"{longestString}\n");
    else
        Console.Write($"{longestString}, ");
}

Console.ReadLine();

static int CheckHorizontal(int col, string[,] matrix, int row, string currentString)
{
    int frequency = 1;

    for (int i = col + 1; i < matrix.GetLength(1); i++)
    {
        if (matrix[row, i] == currentString)
            frequency++;
    }

    return frequency; 
}

static int CheckVertical(int col, string[,] matrix, int row, string currentString)
{
    int frequency = 1;

    for (int i = row + 1; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, col] == currentString)
            frequency++;
    }

    return frequency; 
}

static int CheckDiagonal(int col, string[,] matrix, int row, string currentString)
{
    int frequency = 1;

    for (int i = row + 1, j = col + 1; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
    {
        if (matrix[i, j] == currentString)
            frequency++;
    }

    return frequency; 
}

static int MaxFrequency(int a, int b, int c)
{
    int[] frequencies = { a, b, c };
    return frequencies.Max();
}