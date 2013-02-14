using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTrib = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(firstTrib);
        }
        else if (n == 2)
        {
            Console.WriteLine(secondTrib);
        }
        else if (n == 3)
        {
            Console.WriteLine(thirdTrib);
        }
        else
        {
            for (int i = 4; i <= n; i++)
            {
                BigInteger nextTrib = firstTrib + secondTrib + thirdTrib;
                firstTrib = secondTrib;
                secondTrib = thirdTrib;
                thirdTrib = nextTrib;
            }
            Console.WriteLine(thirdTrib);
        }
    }
}