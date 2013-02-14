using System;

class MaxSumSequenceInKElements
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //int k = int.Parse(Console.ReadLine());

        int[] arr = new int[] { 1, 2, -3, 4, -5, 6, 7, -8, 3, 9 };
        int k = 3;
        int maxSum = int.MinValue;
        int startIndex = -1;

        for (int i = 0; i < arr.Length - k; i++)
        {
            int sum = 0;
            for (int j = i; j < i + k; j++)
            {
                sum += arr[j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                startIndex = i;
            }
        }
        Console.WriteLine(maxSum);

        for (int i = startIndex; i < startIndex + k; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}