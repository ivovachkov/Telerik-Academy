using System;

namespace Occurrence
{
    public class NumberOccurrences
    {
        static void Main()
        {
            int[] arr = { 2, 3, 4, 5, 2, 3, 4, 5, 32, 4, 5, 3 };
            int result = CountOccurrences(arr, 3);
            Console.WriteLine(result);
        }

        public static int CountOccurrences(int[] arr, int number)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}