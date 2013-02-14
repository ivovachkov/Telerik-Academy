using System;
using System.Collections.Generic;

class Factorial
{
    static void Main()
    {
        List<int> fact = new List<int>() { 1 };
        for (int i = 1; i <= 100; i++)
        {
            fact = Multiply(fact.ToArray(), i);
        }
        Print(fact.ToArray());
    }

    static List<int> Multiply(int[] first, int second)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < second; i++)
        {
            result = Sum(result.ToArray(), first);
        }

        return result;
    }

    static List<int> Sum(int[] first, int[] second)
    {
        int length = Math.Max(first.Length, second.Length);
        List<int> result = new List<int>(length + 1);
        bool carry = false;

        if (first.Length > second.Length)
        {
            Array.Resize(ref second, length);
        }
        else if (first.Length < second.Length)
        {
            Array.Resize(ref first, length);
        }

        for (int i = 0; i < length; i++)
        {
            int sum = first[i] + second[i];

            if (carry)
            {
                sum++;
            }
            if (sum > 9)
            {
                carry = true;
                sum = sum % 10;
            }
            else
            {
                carry = false;
            }
            result.Add(sum);
        }

        if (carry)
        {
            result.Add(1);
        }

        return result;
    }

    static int[] NumberToArray(int number)
    {
        List<int> result = new List<int>();

        while (number > 0)
        {
            int digit = number % 10;
            result.Add(digit);
            number = number / 10;
        }
        return result.ToArray();
    }

    static void Print(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}