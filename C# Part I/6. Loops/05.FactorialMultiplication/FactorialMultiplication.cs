using System;
using System.Numerics;

class FactorialMultiplication
{
    static void Main()
    {
        int n = 21;
        int k = 210000099;
        BigInteger factorialN = 1;
        BigInteger intermediateResult = 1;

        checked
        {
            for (int i = n; i > 1; i--)
            {
                factorialN *= i;
            }

            // calculates K!/(K-N)!
            for (int j = k; j > k - n; j--)
            {
                intermediateResult *= j;
            }
            Console.WriteLine(factorialN * intermediateResult);
        }
    }
}