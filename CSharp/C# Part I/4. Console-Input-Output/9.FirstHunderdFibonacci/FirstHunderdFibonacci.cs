using System;
using System.Numerics;

class FirstHunderdFibonacci
{
    static void Main()
    {
        BigInteger fib0 = 0;
        BigInteger fib1 = 1;

        Console.WriteLine(fib0);
        Console.WriteLine(fib1);

        for (int i = 0; i < 98; i++)
        {
            BigInteger fibNew = fib0 + fib1;
            fib0 = fib1;
            fib1 = fibNew;
            Console.WriteLine(fibNew);
        }
    }
}