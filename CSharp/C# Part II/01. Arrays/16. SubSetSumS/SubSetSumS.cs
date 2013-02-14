using System;

class SubSetSumS
{
    static void Main()
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int s = 14;
        int length = arr.Length;

        for (int i = 1; i < Math.Pow(2, length); i++)
        {
            int sum = 0;
            for (int j = 0; j < length; j++)
            {
                sum += ((i >> j) & 1) * arr[j];
            }
            if (sum == s)
            {
                for (int k = 0; k < length; k++)
                {
                    int number = ((i >> k) & 1) * arr[k];
                    if (number != 0)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}