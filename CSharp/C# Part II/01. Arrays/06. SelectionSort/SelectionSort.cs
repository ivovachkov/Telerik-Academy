using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 3, 4, 2, 7, 1, 4, 5, 2, -4, 0 };

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i];
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minIndex = j;
                }
            }
            arr[minIndex] = arr[i];
            arr[i] = min;
        }

        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }


}