using System;

class FallDown
{
    static void Main()
    {
        int n = 8;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int bit = 0; bit < 8; bit++)
                {
                    if (((numbers[i] >> bit) & 1) > ((numbers[i + 1] >> bit) & 1))
                    {
                        numbers[i + 1] |= 1 << bit;
                        numbers[i] &= ~(1 << bit);
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}