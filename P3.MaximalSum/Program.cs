int[] sizes = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] rowValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValues[col];
    }
}
int maxSquareSum = int.MinValue;
int firstCoordinateRow = 0;
int firstCoordinateCol = 0;

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int currentSquareSum = matrix[row, col] +
                               matrix[row, col + 1] +
                               matrix[row, col + 2] +
                               matrix[row + 1, col] +
                               matrix[row + 1, col + 1] +
                               matrix[row + 1, col + 2] +
                               matrix[row + 2, col] +
                               matrix[row + 2, col + 1] +
                               matrix[row + 2, col + 2];

        if (currentSquareSum > maxSquareSum)
        {
            maxSquareSum = currentSquareSum;
            firstCoordinateRow = row;
            firstCoordinateCol = col;
        }
    }
}
Console.WriteLine($"Sum = {maxSquareSum}");
for (int row = firstCoordinateRow; row < firstCoordinateRow + 3; row++)
{
    for (int col = firstCoordinateCol; col < firstCoordinateCol + 3; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}