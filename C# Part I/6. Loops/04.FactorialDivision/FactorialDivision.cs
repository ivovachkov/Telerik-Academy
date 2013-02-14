using System;

class FactorialDivision
{
    static void Main()
    {
        int n = 5;
        int k = 178;
        double result = 1.0;

        for (int counter = k; counter > n; counter--)
        {
            result *= 1.0 / counter;
        }
        Console.WriteLine(result);
    }
}