using System;

class ZeroSumSubset
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, -2, 0 };
        int counterZeroSum = 0;
        int length = numbers.Length;

        for (int i = 1; i < Math.Pow(2, length); i++)
        {
            int sum = 0;
            for (int j = 0; j < length; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }

            if (sum == 0)
            {
                counterZeroSum++;

                for (int m = 0; m < length; m++)
                {
                    if (((i >> m) & 1) == 1)
                    {
                        Console.Write(numbers[m] + "|");
                    }
                }
                Console.WriteLine();

                /*
                //Printing on the console using String
                string mem = Convert.ToString(i, 2).PadLeft(5, '0');
                for (int k = 0; k < length; k++)
                {
                    if (mem[k] == '1')
                    {
                        Console.Write(numbers[length - 1 - k] + "  ");
                    }
                }
                Console.WriteLine();
                */
            }
        }
        Console.WriteLine(counterZeroSum + " subsets have sum zero");
    }
}