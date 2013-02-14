using System;
using System.Numerics;
using System.Collections.Generic;

class Brackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int length = input.Length;
        List<BigInteger> result = new List<BigInteger>(new BigInteger[1000]);
        result[0] = 1;

        for (int i = 0; i < length; i++)
        {
            if (input[i] == '(')
            {
                result.Insert(0, 0);
            }
            else if (input[i] == ')')
            {
                result.RemoveAt(0);
            }
            else if (input[i] == '?')
            {
                result.Insert(0, result[1]);

                for (int k = 1; k < i + 10; k++)
                {
                    result[k] += result[k + 2];
                }
            }
        }
        Console.WriteLine(result[0]);
    }
}