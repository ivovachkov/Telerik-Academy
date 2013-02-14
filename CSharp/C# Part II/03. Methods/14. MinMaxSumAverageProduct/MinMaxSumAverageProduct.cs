using System;

class MinMaxSumAverageProduct
{
    static void Main()
    {
        Console.WriteLine(SumNumbers(1, 2, 3, 4, 1, 2222222, 8, 1212));
        Console.WriteLine(ProductNumbers(1, 2, 3, 4, 1, 2222222, 8, 1212));
        Console.WriteLine(AverageNumbers(1, 2, 3, 4, 1, 2222222, 8, 1212));
        Console.WriteLine(MinNumbers(1, 2, 3, 4, 1, 2222222, 8, 1212));
        Console.WriteLine(MaxNumbers(1, 2, 3, 4, 1, 2222222, 8, 1212));
    }

    static long SumNumbers(params int[] elements)
    {
        long sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return sum;
    }

    static long ProductNumbers(params int[] elements)
    {
        long product = 1;
        foreach (var item in elements)
        {
            product *= item;
        }
        return product;
    }

    static long AverageNumbers(params int[] elements)
    {
        long sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return sum / elements.Length;
    }

    static int MinNumbers(params int[] elements)
    {
        int min = int.MaxValue;

        foreach (var item in elements)
        {
            if (item < min)
            {
                min = item;
            }
        }

        return min;
    }

    static int MaxNumbers(params int[] elements)
    {
        int max = int.MinValue;

        foreach (var item in elements)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }
}