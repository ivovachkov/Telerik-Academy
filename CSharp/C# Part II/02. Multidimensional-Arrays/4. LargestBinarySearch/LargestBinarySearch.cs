using System;

public class LargestBinarySearch
{
    static void Main()
    {
        int k = 5;
        int[] arr = new int[] { 3,2,1,4,8,9,6,7,4,3,2 };

        Array.Sort(arr);
        Console.WriteLine(string.Join(" ", arr));

        int resultIndex = Array.BinarySearch(arr, k);
        resultIndex = Math.Abs(resultIndex);

        if (arr[resultIndex] == k)
        {
            Console.WriteLine(k);
        }
        else
        {
            Console.WriteLine(arr[resultIndex - 2]);
        }
    }
}