using System;

class SubSetSumKS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            int sum = 0;
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                int bit = (i >> j) & 1;
                if ((bit == 1) && (count < k))
                {
                    sum += bit * arr[j];
                    count++;
                }
            }
            if ((sum == s) && (count == k))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}