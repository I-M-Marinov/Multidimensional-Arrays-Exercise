﻿namespace P4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] matrix = new string[rows, cols];
            ReadTheMatrix(rows, cols, matrix);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputTokens = input.Split();
                string command = inputTokens[0];
                if (command == "swap" && inputTokens.Length == 5)
                {
                    int row1 = int.Parse(inputTokens[1]);
                    int col1 = int.Parse(inputTokens[2]);

                    int row2 = int.Parse(inputTokens[3]);
                    int col2 = int.Parse(inputTokens[4]);

                    if (row1 >= 0 && col1 >= 0 && row2 >= 0 && col2 >= 0 && row1 < rows && row2 < rows && col1 < cols && col2 < cols)
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        PrintTheMatrix(rows, cols, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void PrintTheMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadTheMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}


