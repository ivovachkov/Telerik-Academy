using System;

namespace Neighbours
{
    public class NeighboursCheck
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 4, 23, 23, 223, 123, 434, 23, 53, 2 };

            Console.WriteLine(CheckNeighbours(arr, 90) ? "Yes" : "No");
        }

        public static bool CheckNeighbours(int[] arr, int index)
        {
            bool result = false;

            if (AreNeighboursInArray(arr, index))
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    result = true;
                }
            }

            return result;
        }

        static bool AreNeighboursInArray(int[] arr, int index)
        {
            bool result = false;
            if (((index - 1) >= 0) && ((index + 1) < arr.Length))
            {
                result = true;
            }
            return result;
        }
    }
}