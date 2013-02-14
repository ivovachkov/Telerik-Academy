using System;

class Pillars
{
    static void Main()
    {
        int[,] grid = new int[8,8];
        int bestCount = -1;
        int bestCol = -1;

        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if (((number >> col) & 1) == 1)
                {
                    grid[row, col] = 1;
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            int leftCount = 0;
            int rightCount = 0;

            for (int col = 0; col < i; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (grid[row, col] == 1)
                    {
                        leftCount++;
                    }
                }
            }

            for (int col = i + 1; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (grid[row, col] == 1)
                    {
                        rightCount++;
                    }
                }
            }

            if (leftCount == rightCount)
            {
                bestCol = i;
                bestCount = leftCount;
            }
        }

        if ((bestCount != -1) && (bestCol != -1))
        {
            Console.WriteLine(bestCol);
            Console.WriteLine(bestCount);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}