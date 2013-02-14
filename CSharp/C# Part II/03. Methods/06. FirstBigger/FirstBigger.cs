using System;
using Neighbours;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 24, 34, 67, 68, 69, 70, 80, 90 };

        for (int i = 0; i < arr.Length; i++)
        {
            if (NeighboursCheck.CheckNeighbours(arr, i))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}