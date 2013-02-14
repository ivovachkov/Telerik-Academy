using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        int n = 150000;
        BigInteger catalanNumber = 0;
        BigInteger dividend = 1;
        BigInteger factorialN = 1;

        checked
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                dividend *= i;
                factorialN *= (i - n);
            }
            catalanNumber = dividend / factorialN;
            Console.WriteLine(catalanNumber);
        }
    }
}