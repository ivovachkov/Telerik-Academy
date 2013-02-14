using System;

class TrailingZerosOptimized
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int trailingZeros = 0;

        DateTime start = DateTime.Now;

        for (int i = 1; i <= n; i++)
        {
            trailingZeros += (int)(n / Math.Pow(5, i));
        }
        Console.WriteLine("Trailing Zeros = " + trailingZeros);

        DateTime finish = DateTime.Now;
        Console.WriteLine("Time used = {0}", finish - start);
    }
}