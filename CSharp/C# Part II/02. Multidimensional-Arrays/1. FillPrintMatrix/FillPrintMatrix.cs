using System;

class FillPrintMatrix
{
    static int n = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[,] matrix = new int[n, n];

        FillMatrixA(matrix);
        PrintMatrix(matrix);

        FillMatrixB(matrix);
        PrintMatrix(matrix);

        FillMatrixC(matrix);
        PrintMatrix(matrix);

        FillMatrixD(matrix);
        PrintMatrix(matrix);
    }

    static void FillMatrixA(int[,] matrix)
    {
        int num = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = num;
                num++;
            }
        }
    }

    static void FillMatrixB(int[,] matrix)
    {
        int num = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            num = GetDirectionB(num, col);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = num;
                num = GetDirectionB(num, col);
            }

            num += n;
        }
    }

    static int GetDirectionB(int num, int col)
    {
        if (col % 2 == 0)
        {
            num++;
        }
        else
        {
            num--;
        }
        return num;
    }

    static void FillMatrixC(int[,] matrix)
    {
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            int row = n - i;
            int col = 0;
            for (int j = 1; j <= i; j++)
            {
                matrix[row, col] = num;
                num++;
                row++;
                col++;
            }
        }

        for (int i = 1; i < n; i++)
        {
            int row = 0;
            int col = i;
            for (int j = n - 1; j >= i; j--)
            {
                matrix[row, col] = num;
                num++;
                row++;
                col++;
            }
        }
    }

    static void FillMatrixD(int[,] matrix)
    {
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            matrix[i, 0] = num;
            num++;
        }

        int row = n - 1;
        int col = 0;
        int direction = 0;
        for (int j = 1; j < n; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                for (int i = n - j; i > 0; i--)
                {
                    switch (direction)
                    {
                        case 0:
                            col++;
                            break;
                        case 1:
                            row--;
                            break;
                        case 2:
                            col--;
                            break;
                        case 3:
                            row++;
                            break;
                        default:
                            break;
                    }
                    matrix[row, col] = num;
                    num++;
                }
                direction++;
                direction %= 4;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}