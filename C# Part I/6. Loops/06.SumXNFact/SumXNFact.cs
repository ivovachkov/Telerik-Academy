using System;
using System.Numerics;

class SumXNFact
{
    static void Main()
    {
        int n = 90;
        int x = -2;
        BigInteger factorialN = 1;
        double sum = 1.0;

        DateTime start = DateTime.Now;

        checked
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                BigInteger xPowN = (BigInteger)Math.Pow(x, i);
                sum += ((double)factorialN / (double)xPowN);
            }
            Console.WriteLine(sum);
        }

        DateTime final = DateTime.Now;
        Console.WriteLine(final - start);
    }
}