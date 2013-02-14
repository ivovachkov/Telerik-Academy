using System;

class MaximalSequence
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int count = 1;
        int bestNum = 0;
        int bestCount = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;
                if (bestCount < count)
                {
                    bestCount = count;
                    bestNum = arr[i];
                }
            }
            else
            {
                count = 1;
            }
        }

        for (int j = 0; j < bestCount; j++)
        {
            Console.Write(bestNum + " ");
        }
        Console.WriteLine();
    }
}