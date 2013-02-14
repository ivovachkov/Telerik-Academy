using System;

class Guitar
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] tokens = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int length = tokens.Length + 1;
        int[] numbers = new int[length];

        for (int i = 1; i < length; i++)
        {
            numbers[i] = int.Parse(tokens[i - 1]);
        }

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int max = -1;

        int[,] table = new int[length, end + 1];

        table[0, start] = 1;
        for (int row = 1; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                int index = table[row - 1, col];
                if (index == 1)
                {
                    if (col + numbers[row] <= end)
                    {
                        table[row, col + numbers[row]] = 1;
                    }
                    if (col - numbers[row] >= 0)
                    {
                        table[row, col - numbers[row]] = 1;
                    }
                }
            }
        }

        for (int i = end; i >= 0; i--)
        {
            if (table[length - 1, i] == 1)
            {
                max = i;
                break;
            }
        }
        Console.WriteLine(max);
    }
}