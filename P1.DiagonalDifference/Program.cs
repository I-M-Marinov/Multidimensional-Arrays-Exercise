

static int[,] ReadMatrixOnOneLine(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }
    return matrix;
}

static int DiagonalDifference(int primary, int secondary)
{
    int totalSum = primary - secondary;
    return totalSum;
}

int n = int.Parse(Console.ReadLine());
int[,] matrix = ReadMatrixOnOneLine(n, n);
int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    primaryDiagonalSum += matrix[i, i];
}

for (int j = 0; j < matrix.GetLength(0); j++)
{
    secondaryDiagonalSum += matrix[j, matrix.GetLength(1) - j - 1];
}

Console.WriteLine($"{Math.Abs(DiagonalDifference(primaryDiagonalSum, secondaryDiagonalSum))}");
