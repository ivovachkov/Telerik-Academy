using System;
using System.Collections.Generic;

class MaxArea
{
    static bool[,] visited = new bool[50, 50];

    static void Main()
    {
        //int[,] matrix =            
        //    {
        //    {3,3,3,3,2,4},
        //    {1,3,2,3,4,4},
        //    {4,3,1,2,3,3},
        //    {4,3,1,3,3,1},
        //    {4,3,3,3,1,1}
        //    };

        int[,] matrix =            
            {
            {1,3,2,2,2,4},
            {3,3,3,2,4,4},
            {4,3,1,2,3,3},
            {4,3,1,3,3,1},
            {4,3,3,3,1,1}
            };

        int rowLenght = matrix.GetLength(0);
        int colLenght = matrix.GetLength(1);
        int maxLen = -1;

        for (int row = 0; row < rowLenght; row++)
        {
            for (int col = 0; col < colLenght; col++)
            {
                int currentLen = DFS(matrix, row, col);
                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                }
            }
        }
        Console.WriteLine(maxLen);

    }

    static bool InRange(int[,] matrix, int row, int col)
    {
        bool result;
        result = (row >= 0) && (col >= 0) &&
            (row < matrix.GetLength(0)) && (col < matrix.GetLength(1));
        return result;
    }

    static int DFS(int[,] matrix, int row, int col)
    {
        Stack<int> path = new Stack<int>();
        int[] rowDirections = { 1, -1, 0, 0 };
        int[] colDirections = { 0, 0, 1, -1 };
        int count = 1;
        path.Push(row);
        path.Push(col);

        int nextRow = row;
        int nextCol = col;
        visited[nextRow, nextCol] = true;

        while (path.Count > 0)
        {
            //int stackSize = path.Count;
            int inCount = 0;
            for (int i = 0; i < 4; i++)
            {
                if ((InRange(matrix, nextRow + rowDirections[i], nextCol + colDirections[i]))
                    && (!visited[nextRow + rowDirections[i], nextCol + colDirections[i]]))
                {
                    if ((matrix[nextRow, nextCol] == matrix[nextRow + rowDirections[i], nextCol + colDirections[i]]))
                    {
                        inCount++;
                        count++;
                        nextRow = nextRow + rowDirections[i];
                        nextCol = nextCol + colDirections[i];
                        visited[nextRow, nextCol] = true;
                        path.Push(nextRow);
                        path.Push(nextCol);
                        break;
                    }
                }
            }

            if (inCount == 0) // check if we found equal element
            {
                nextCol = path.Pop();
                nextRow = path.Pop();
            }
        }

        return count;
    }
}