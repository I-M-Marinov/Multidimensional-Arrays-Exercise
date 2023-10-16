
using System;

List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int rows = input[0];
int cols = input[1];
char[,] matrix = new char[rows, cols];

char[] snakeTokens = Console.ReadLine().ToCharArray();
int index = -1;

for (int i = 0; i < rows; i++)
{

    if (i % 2 == 0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (index == snakeTokens.Length - 1)
            {
                index = -1;
            }
            index++;
            matrix[i, j] = snakeTokens[index];
        }
    }
    else
    {
        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
        {

            if (index == snakeTokens.Length - 1)
            {
                index = -1;
            }
            index++;
            matrix[i, j] = snakeTokens[index];
        }
    }
}

PrintMatrix(matrix);

static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }
}


