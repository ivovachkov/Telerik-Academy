using System;
using System.Text;

class Matrix
{
    private int rows;
    private int cols;
    private int[,] matrix;

    public int this[int x, int y]
    {
        get { return matrix[x, y]; }
        set { matrix[x, y] = value; }
    }

    public int Rows
    {
        get
        {
            return this.rows;
        }
        set
        {
            this.rows = value;
        }
    }

    public int Cols
    {
        get
        {
            return this.cols;
        }
        set
        {
            this.cols = value;
        }
    }

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new int[rows, cols];
    }

    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
        for (int row = 0; row < firstMatrix.rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                resultMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.rows, firstMatrix.cols);
        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                resultMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Rows, secondMatrix.Cols);
        for (int row = 0; row < resultMatrix.Rows; row++)
        {
            for (int col = 0; col < resultMatrix.Cols; col++)
            {
                for (int i = 0; i < secondMatrix.Rows; i++)
                {
                    resultMatrix[row, col] += firstMatrix[row, i] * secondMatrix[i, col];
                }
            }
        }
        return resultMatrix;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.cols; j++)
            {
                result.Append(string.Format("{0,3}", this.matrix[i, j]));
            }
            result.Append("\n");
        }
        return result.ToString();
    }
}

public class Prgram
{
    static void Main()
    {
        Matrix m1 = new Matrix(3, 3);
        Matrix m2 = new Matrix(3, 3);

        FillMatrix(m1, m2);

        Console.WriteLine("First Matrix\n" + m1 + "-----------");
        Console.WriteLine("Second Matrix\n" + m2 + "-----------");

        Console.WriteLine("Add");
        Matrix res = m1 + m2;
        Console.WriteLine(res + "-----------");

        Console.WriteLine("Subtract");
        res = m1 - m2;
        Console.WriteLine(res + "-----------");

        Console.WriteLine("Multiply");
        res = m1 * m2;
        Console.WriteLine(res);
    }

    static void FillMatrix(Matrix m1, Matrix m2)
    {
        Random rand = new Random();
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                m1[i, j] = rand.Next(1, 5);
                m2[i, j] = rand.Next(1, 5);
            }
        }
    }
}