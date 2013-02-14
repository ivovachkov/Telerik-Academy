using System;

class MaxSumSequence
{
    static int[] arr = new int[] { 1, -1, 3, 4, -7, 6, 7, 8, 9, 10, 11, 12, 13 };

    static void Main()
    {
        int sum = arr[0];
        int maxSum = arr[0];
        int start = 0;
        int bestStart = 0;
        int end = 0;

        for (int index = 1; index < arr.Length; index++)
        {
            sum += arr[index];
            if (sum < arr[index])
            {
                sum = arr[index];
                start = index;
            }
            if (maxSum < sum)
            {
                maxSum = sum;
                end = index;
                bestStart = start;
            }
        }
        Console.WriteLine("Max sum is: " + maxSum);
        PrintNumbersInSum(bestStart, end);
    }

    static void PrintNumbersInSum(int min, int max)
    {
        for (int index = min; index <= max; index++)
        {
            Console.Write(arr[index] + " ");
        }
        Console.WriteLine();
    }
}