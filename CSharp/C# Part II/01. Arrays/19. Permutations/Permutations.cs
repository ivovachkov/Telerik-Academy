﻿using System;

class Permutations
{
    static void Main()
    {
        int[] arr = new int[int.Parse(Console.ReadLine())];
        bool[] used = new bool[arr.Length];

        Permutation(arr, used, 0);
    }

    static void Permutation(int[] arr, bool[] used, int index)
    {
        if (index == arr.Length)
        {
            PrintArray(arr);
        }
        else
        {
            for (int start = 1; start <= arr.Length; start++)
            {
                if (!used[start - 1])
                {
                    arr[index] = start;
                    used[start - 1] = true;
                    Permutation(arr, used, index + 1);
                    used[start - 1] = false;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}