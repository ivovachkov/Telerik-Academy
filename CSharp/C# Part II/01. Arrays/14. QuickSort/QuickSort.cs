using System;
using System.Collections.Generic;

class QuickSortPogram
{
    static void Main()
    {
        List<int> unsortedList = new List<int> { 3, 5, 1, 2, 9, 6, 4, 5, 3, 2 };
        List<int> sortedList = QuickSort(unsortedList);
        foreach (int number in sortedList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static List<int> QuickSort(List<int> unsortedList)
    {
        Random rand = new Random();
        List<int> less = new List<int>();
        List<int> greater = new List<int>();
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }
        int pos = rand.Next(unsortedList.Count);
        int pivot = unsortedList[pos];
        unsortedList.RemoveAt(pos);
        foreach (int x in unsortedList)
        {
            if (x <= pivot)
            {
                less.Add(x);
            }
            else
            {
                greater.Add(x);
            }
        }
        return Concat(QuickSort(less), pivot, QuickSort(greater));
    }

    static List<int> Concat(List<int> less, int pivot, List<int> greater)
    {
        List<int> sorted = new List<int>(less);
        sorted.Add(pivot);
        foreach (int number in greater)
        {
            sorted.Add(number);
        }
        return sorted;
    }
}