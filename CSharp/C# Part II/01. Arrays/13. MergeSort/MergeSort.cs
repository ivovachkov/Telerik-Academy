using System;
using System.Collections.Generic;

class MergeSortProgram
{
    static void Main()
    {
        List<int> unsortedList = new List<int> { 3, 4, 1, 7, 4, 5, 3, 2, 1 };
        List<int> sortedList = MergeSort(unsortedList);

        PrintList(sortedList);
    }
    
    static List<int> MergeSort(List<int> unsorted)
    {
        if (unsorted.Count <= 1)
        {
            return unsorted;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = unsorted.Count / 2;

        for (int i = 0; i < middle; i++)
        {
            left.Add(unsorted[i]);
        }

        for (int j = middle; j < unsorted.Count; j++)
        {
            right.Add(unsorted[j]);
        }

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> merged = new List<int>();
        while (left.Count > 0 && right.Count > 0)
        {
            if (left[0] < right[0])
            {
                merged.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                merged.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        while (left.Count > 0)
        {
            merged.Add(left[0]);
            left.RemoveAt(0);
        }
        while (right.Count > 0)
        {
            merged.Add(right[0]);
            right.RemoveAt(0);
        }

        return merged;
    }

    static void PrintList(List<int> list)
    {
        foreach (int number in list)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}