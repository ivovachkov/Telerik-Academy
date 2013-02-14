using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int len = 0;
        int lastBit = -1;
        int dancingBits = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNonZeroBit = -1;
            for (int j = 31; j >= 0; j--)
            {
                int currentBit = (number >> j) & 1;
                if (currentBit != 0)
                {
                    firstNonZeroBit = j;
                    break;
                }
            }

            for (int j = firstNonZeroBit; j >= 0; j--)
            {
                int currentBit = (number >> j) & 1;
                if (currentBit == lastBit)
                {
                    len++;
                }
                else
                {
                    if (len == k)
                    {
                        dancingBits++;
                    }
                    len = 1;
                }
                lastBit = currentBit;
            }
        }
        if (len == k)
        {
            dancingBits++;
        }
        Console.WriteLine(dancingBits);
    }
}