using System;
using System.Text;
using System.Collections.Generic;

class SegmentDigits
{
    static int[] digits = new int[10];

    static int n = int.Parse(Console.ReadLine());
    static int[] numbers = new int[n];
    static int[] arr = new int[n];

    static int counter = 0;
    static StringBuilder result = new StringBuilder();

    static void Main()
    {
        GetBinaryNumber();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            numbers[i] = Convert.ToInt32(input, 2);
        }

        Variate(0);

        Console.WriteLine(counter);
        Console.Write(result);
    }

    static void Variate(int index)
    {
        if (index == n)
        {
            for (int i = 0; i < n; i++)
            {
                result.Append(arr[i]);
            }
            result.AppendLine();
            counter++;
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                if ((numbers[index] & digits[i]) == numbers[index])
                {
                    arr[index] = i;
                    Variate(index + 1);
                }
            }
        }
    }

    static void GetBinaryNumber()
    {
        digits[0] = Convert.ToInt32("1111110", 2);
        digits[1] = Convert.ToInt32("0110000", 2);
        digits[2] = Convert.ToInt32("1101101", 2);
        digits[3] = Convert.ToInt32("1111001", 2);
        digits[4] = Convert.ToInt32("0110011", 2);
        digits[5] = Convert.ToInt32("1011011", 2);
        digits[6] = Convert.ToInt32("1011111", 2);
        digits[7] = Convert.ToInt32("1110000", 2);
        digits[8] = Convert.ToInt32("1111111", 2);
        digits[9] = Convert.ToInt32("1111011", 2);
    }
}