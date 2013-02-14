using System;

class Polynomials
{
    static void Main()
    {
        decimal[] first = { 5, 0, 1, 3, 0, 5 };
        decimal[] second = { 7, -3, 3, 4, 0, 6 };

        Console.Write("First polynomial: ");
        PrintResult(first);

        Console.Write("Second polynomial: ");
        PrintResult(second);

        decimal[] addResult = Add(first, second);
        Console.Write("Add: ");
        PrintResult(addResult);

        Console.Write("Subtract: ");
        decimal[] subResult = Subtract(first, second);
        PrintResult(subResult);

        Console.Write("Multiply: ");
        decimal[] multiplyResult = Multiply(first, second);
        PrintResult(multiplyResult);
    }

    static decimal[] Add(decimal[] first, decimal[] second)
    {
        int length = first.Length;
        decimal[] sum = new decimal[length];

        for (int i = 0; i < length; i++)
        {
            sum[i] = first[i] + second[i];
        }

        return sum;
    }

    static decimal[] Subtract(decimal[] first, decimal[] second)
    {
        int length = first.Length;
        decimal[] difference = new decimal[length];

        for (int i = 0; i < length; i++)
        {
            difference[i] = first[i] - second[i];
        }

        return difference;
    }

    static decimal[] Multiply(decimal[] first, decimal[] second)
    {
        int length = first.Length;
        decimal[] product = new decimal[length * 2 - 1];

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                int productIndex = i + j;
                product[productIndex] += first[i] * second[j];
            }
        }

        return product;
    }

    static void PrintResult(decimal[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i < arr.Length - 1)
            {
                if (arr[i] > 0)
                {
                    Console.Write(" + ");
                }
                else if (arr[i] < 0)
                {
                    Console.Write(" - ");
                    arr[i] *= -1;
                }
            }

            if (arr[i] != 0)
            {
                Console.Write(arr[i]);
                if (i > 0)
                {
                    Console.Write("x");
                    if (i > 1)
                    {
                        Console.Write("^{0}", i);
                    }
                }
            }
        }
        Console.WriteLine();
    }
}