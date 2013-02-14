using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger firstTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTrib = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(firstTrib);
        Console.WriteLine("{0} {1}", secondTrib, thirdTrib);

        if (n > 2)
        {
            for (int i = 3; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    BigInteger nextTrib = firstTrib + secondTrib + thirdTrib;
                    firstTrib = secondTrib;
                    secondTrib = thirdTrib;
                    thirdTrib = nextTrib;
                    if (j == i)
                    {
                        Console.WriteLine(thirdTrib);
                    }
                    else
                    {
                        Console.Write(thirdTrib + " ");
                    }
                }
            }
        }
    }
}