using System;

class SortDescending
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 231, 13, 41, 34, 312 };
        SelectionSortDescedning(arr);
        Console.WriteLine(string.Join(" ", arr));
    }

    static int MaxIndex(int[] arr, int start)
    {
        int max = int.MinValue;
        int maxIndex = -1;

        for (int i = start; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxIndex = i;

            }
        }

        return maxIndex;
    }

    static void SelectionSortDescedning(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int maxIndex = MaxIndex(arr, i);
            Swap(ref arr[maxIndex], ref arr[i]);
        }
    }

    static void Swap(ref int first, ref int second)
    {
        int swap = first;
        first = second;
        second = swap;
    }
}