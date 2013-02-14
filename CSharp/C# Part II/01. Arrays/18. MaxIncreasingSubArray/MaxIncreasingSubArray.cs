using System;
using System.Collections.Generic;

class MaxIncreasingSubArray
{
    static void Main()
    {
        int[] numbers = new int[] { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int length = numbers.Length;
        int maxCount = 0;
        List<int> maxResult = new List<int>();

        for (int i = 1; i < Math.Pow(2, length); i++)
        {
            List<int> result = new List<int>();
            int count = 0;
            for (int j = 0; j < length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    result.Add(numbers[j]);
                    if ((result.Count > 1) && (result[result.Count - 1] >= result[result.Count - 2]))
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxResult = result;
            }
        }

        foreach (var item in maxResult)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}