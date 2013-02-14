using System;

class SumSequence
{
    static void Main()
    {
        int[] arr = { 4, 3, 4, 1, 4, 2, 5, 0, 8 };
        int s = 11;

        for (int start = 0; start < arr.Length - 1; start++)
        {
            int sum = arr[start];
            for (int end = start + 1; end < arr.Length; end++)
            {
                sum += arr[end];
                if (sum == s)
                {
                    for (int index = start; index <= end; index++)
                    {
                        Console.Write(arr[index] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}