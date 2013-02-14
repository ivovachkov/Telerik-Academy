using System;
using System.IO;
using System.Text;

class MaxSumMatrix
{
    static void Main()
    {
        string inputFile = "..\\..\\input.txt";
        string outputFile = "..\\..\\ouput.txt";
        Encoding encoding = Encoding.GetEncoding("utf-8");
        StreamReader reader = new StreamReader(inputFile, encoding);
        StreamWriter writer = new StreamWriter(outputFile, false, encoding);

        int n;
        int[,] matrix;
        int maxSum = int.MinValue;

        using (reader)
        {
            n = int.Parse(reader.ReadLine());
            matrix = new int[n, n];

            int row = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row, col] = int.Parse(numbers[col]);
                }
                row++;
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col + 1] + matrix[row + 1, col] + matrix[row, col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        using (writer)
        {
            writer.WriteLine(maxSum);
        }
    }
}