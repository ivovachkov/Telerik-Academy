using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            long sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }
            if (sum == s)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}