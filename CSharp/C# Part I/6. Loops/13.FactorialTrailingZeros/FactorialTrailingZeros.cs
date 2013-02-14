using System;
using System.Numerics;

class FactorialTrailingZeros
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        int temp = n;
        BigInteger factorial = 1;
        BigInteger result = 0;
        int counter = 0;

        while (n > 0)
        {
            factorial *= n;
            n--;
        }
        Console.WriteLine("{0}! = {1}", temp, factorial);

        while (result == 0)
        {
            result = factorial % 10;
            if (result == 0)
            {
                counter++;   
            }
            factorial /= 10;
        }
        Console.WriteLine("Trailing zeros = " + counter);
    }
}