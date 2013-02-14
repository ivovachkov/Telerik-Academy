using System;

class StringSequence
{
    //static string[,] matrix = new string[,]
    //    {
    //        { "ha", "fifi", "ho", "hi"},
    //        { "fo", "ha", "hi", "xx"},
    //        { "xxx", "ho", "ha", "xx" },
    //    };

    static string[,] matrix = new string[,]
        {
            { "a", "a", "a", "d", "g", "g", "g" },
            { "b", "a", "c", "d", "e", "f", "g" },
            { "a", "b", "a", "d", "e", "c", "g" },
            { "a", "b", "b", "a", "e", "f", "a" },
            { "a", "b", "c", "d", "b", "f", "g" },
            { "a", "b", "c", "d", "e", "a", "g" },
        };

    //static string[,] matrix = new string[,]
    //    {
    //        { "s", "qq", "s" },
    //        { "pp", "pp", "s" },
    //        { "pp", "qq", "s" },
    //    };

    static int rowLength = matrix.GetLength(0);
    static int colLength = matrix.GetLength(1);

    static int bestLen = 1;
    static string bestString = "";
    static int len = 1;

    static void Main()
    {
        CheckRows();
        CheckCols();
        CheckRightDiagonals();
        CheckLeftDiagonals();

        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(bestString + " ");
        }
        Console.WriteLine();
    }

    static void CheckRows()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            len = 1;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                string current = matrix[row, col];

                CheckBestLen(current, matrix[row, col + 1]);
            }
        }
    }

    static void CheckCols()
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            len = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                string current = matrix[row, col];

                CheckBestLen(current, matrix[row + 1, col]);
            }
        }
    }

    static void CheckRightDiagonals()
    {
        bool[,] checkedElement = new bool[rowLength, colLength];
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                string current = matrix[row, col];
                len = 1;
                if (!checkedElement[row, col])
                {
                    checkedElement[row, col] = true;
                    for (int i = row + 1, j = col + 1; i < rowLength && j < colLength; i++, j++)
                    {
                        CheckBestLen(current, matrix[i, j]);
                        current = matrix[i, j];
                        checkedElement[i, j] = true;
                    }
                }
            }
        }
    }

    static void CheckLeftDiagonals()
    {
        bool[,] checkedElement = new bool[rowLength, colLength];
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                string current = matrix[row, col];
                len = 1;
                if (!checkedElement[row, col])
                {
                    checkedElement[row, col] = true;
                    for (int i = row + 1, j = col - 1; i < rowLength && j > 0; i++, j--)
                    {
                        CheckBestLen(current, matrix[i, j]);
                        current = matrix[i, j];
                        checkedElement[i, j] = true;
                    }
                }
            }
        }
    }

    static void CheckBestLen(string current, string next)
    {
        if (current == next)
        {
            len++;
            if (len > bestLen)
            {
                bestLen = len;
                bestString = current;
            }
        }
        else
        {
            len = 1;
        }
    }
}