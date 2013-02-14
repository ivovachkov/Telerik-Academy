using System;

class SumFibonacci
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        uint n = uint.Parse(Console.ReadLine());

        ulong fib0 = 0u;
        ulong fib1 = 1u;
        ulong fibNew = 0u;

        for (int i = 0; i < n; i++)
        {
            fibNew = checked(fib0 + fib1);
            fib0 = fib1;
            fib1 = fibNew;
        }
        Console.WriteLine("The sum of the first {0} members of the Fibonacci row is: {1}", n, fibNew - 1);
    }
}