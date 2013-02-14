using System;

class Lines
{
    static void Main()
    {
        int n = 8;
        int[] numbers = new int[n];
        int bestLen = 0;
        int numberMaxLines = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int row = 0; row < numbers.Length; row++)
        {
            int len = 0;
            for (int col = 0; col < n; col++)
            {
                int bit = ((numbers[row] >> col) & 1);
                if (bit == 1)
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        numberMaxLines = 1;
                    }
                    else if (len == bestLen)
                    {
                        numberMaxLines++;
                    }
                }
                else
                {
                    len = 0;
                }
            }
        }

        for (int col = 0; col < n; col++)
        {
            int len = 0;
            for (int row = 0; row < numbers.Length; row++)
            {
                int bit = ((numbers[row] >> col) & 1);
                if (bit == 1)
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        numberMaxLines = 1;
                    }
                    else if (len == bestLen)
                    {
                        numberMaxLines++;
                    }
                }
                else
                {
                    len = 0;
                }
            }
        }

        if (bestLen == 1)
        {
            numberMaxLines /= 2;
        }

        Console.WriteLine(bestLen);
        Console.WriteLine(numberMaxLines);
    }
}