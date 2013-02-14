using System;

class MultiplyBy5Index
{
    static void Main()
    {
        int n = 20;
        int[] arr = new int[n];

        for (int index = 0; index < arr.Length; index++)
        {
            arr[index] = index * 5;
            Console.Write(arr[index] + " ");
        }
        Console.WriteLine();
    }
}