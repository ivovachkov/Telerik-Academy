using System;

class Generics
{
    static void Main()
    {
        int[] intNumbers = { 1, 2, -44, 0, 434242 };
        double[] doubleNumbers = { 2.323423, 4.23, 0.23232, -0.32323, 7 };
        float[] floatNumbers = { 2.323423f, 4.23f, 0.23232f, -0.32323f, 7f };
        decimal[] decimalNumbers = { 2.323423m, 4.23m, 0.23232m, -0.32323m, 7m };

        Console.WriteLine(Product(intNumbers[0], intNumbers[1], intNumbers[2], intNumbers[3], intNumbers[4]));
        Console.WriteLine(Min(intNumbers[0], intNumbers[1], intNumbers[2], intNumbers[3], intNumbers[4]));
        Console.WriteLine(Max(intNumbers[0], intNumbers[1], intNumbers[2], intNumbers[3], intNumbers[4]));
        Console.WriteLine(Average(intNumbers[0], intNumbers[1], intNumbers[2], intNumbers[3], intNumbers[4]));
        Console.WriteLine(Sum(intNumbers[0], intNumbers[1], intNumbers[2], intNumbers[3], intNumbers[4]));
        Console.WriteLine();

        Console.WriteLine(Product(doubleNumbers[0], doubleNumbers[1], doubleNumbers[2], doubleNumbers[3], doubleNumbers[4]));
        Console.WriteLine(Min(doubleNumbers[0], doubleNumbers[1], doubleNumbers[2], doubleNumbers[3], doubleNumbers[4]));
        Console.WriteLine(Max(doubleNumbers[0], doubleNumbers[1], doubleNumbers[2], doubleNumbers[3], doubleNumbers[4]));
        Console.WriteLine(Average(doubleNumbers[0], doubleNumbers[1], doubleNumbers[2], doubleNumbers[3], doubleNumbers[4]));
        Console.WriteLine(Sum(doubleNumbers[0], doubleNumbers[1], doubleNumbers[2], doubleNumbers[3], doubleNumbers[4]));
        Console.WriteLine();

        Console.WriteLine(Product(floatNumbers[0], floatNumbers[1], floatNumbers[2], floatNumbers[3], floatNumbers[4]));
        Console.WriteLine(Min(floatNumbers[0], floatNumbers[1], floatNumbers[2], floatNumbers[3], floatNumbers[4]));
        Console.WriteLine(Max(floatNumbers[0], floatNumbers[1], floatNumbers[2], floatNumbers[3], floatNumbers[4]));
        Console.WriteLine(Average(floatNumbers[0], floatNumbers[1], floatNumbers[2], floatNumbers[3], floatNumbers[4]));
        Console.WriteLine(Sum(floatNumbers[0], floatNumbers[1], floatNumbers[2], floatNumbers[3], floatNumbers[4]));
        Console.WriteLine();

        Console.WriteLine(Product(decimalNumbers[0], decimalNumbers[1], decimalNumbers[2], decimalNumbers[3], decimalNumbers[4]));
        Console.WriteLine(Min(decimalNumbers[0], decimalNumbers[1], decimalNumbers[2], decimalNumbers[3], decimalNumbers[4]));
        Console.WriteLine(Max(decimalNumbers[0], decimalNumbers[1], decimalNumbers[2], decimalNumbers[3], decimalNumbers[4]));
        Console.WriteLine(Average(decimalNumbers[0], decimalNumbers[1], decimalNumbers[2], decimalNumbers[3], decimalNumbers[4]));
        Console.WriteLine(Sum(decimalNumbers[0], decimalNumbers[1], decimalNumbers[2], decimalNumbers[3], decimalNumbers[4]));
    }

    static T Sum<T>(params T[] elements)
    {
        dynamic sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return sum;
    }

    static T Product<T>(params T[] elements)
    {
        dynamic product = 1;
        foreach (var item in elements)
        {
            product *= item;
        }
        return product;
    }

    static T Average<T>(params T[] elements)
    {
        dynamic sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return sum / elements.Length;
    }

    static T Min<T>(params T[] elements)
    {
        dynamic min = elements[0];

        for (var i = 1; i < elements.Length; i++)
        {
            if (elements[i] < min)
            {
                min = elements[i];
            }
        }

        return min;
    }

    static T Max<T>(params T[] elements)
    {
        dynamic max = elements[0];

        for (var i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }

        return max;
    }
}