static string[,] ReadMatrixOnOneLine(int rows, int cols)
{
    string[,] matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] rowValues = Console.ReadLine().Split(' ').ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rows = dimentions[0];
int cols = dimentions[1];

string[,] matrix = ReadMatrixOnOneLine(rows, cols);
int counter = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int  col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        string currentSymbol = matrix[row, col];

        if (currentSymbol == matrix[row,col+1])
        {
            if (currentSymbol == matrix[row+1, col])
            {
                if (currentSymbol == matrix[row + 1, col + 1])
                {
                    counter++;
                }
            }
        }
    }
}
Console.WriteLine(counter);
