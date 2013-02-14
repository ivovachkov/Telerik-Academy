using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 2, 2, 8 };
        int count = 1;
        int bestCount = 0;
        int bestIndex = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] > arr[i])
            {
                count++;
                if (bestCount < count)
                {
                    bestCount = count;
                    bestIndex = i + 1;
                }
            }
            else
            {
                count = 1;
            }
        }

        for (int i = bestCount - 1; i >= 0; i--)
        {
            Console.Write(arr[bestIndex - i] + " ");
        }
        Console.WriteLine();
    }
}