using System;

class MaxSumSquare
{
    static void Main()
    {
        int n = 3;
        int[,] matrix = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { -1, -2, 3, 4 },
            { 5, 6, 7, 8 },
        };
        int bestSum = int.MinValue;
        int bestRow = -1;
        int bestCol = -1;

        for (int row = 0; row <= matrix.GetLength(0) - n; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - n; col++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sum += matrix[row + i, col + j];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine(bestSum);

        for (int row = bestRow; row < bestRow + n; row++)
        {
            for (int col = bestCol; col < bestCol + n; col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
