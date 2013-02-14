using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        bool[] isFound = new bool[n];
        int index = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (!isFound[i])
                {
                    if (numbers[i] == numbers[j])
                    {
                        isFound[i] = true;
                        isFound[j] = true;
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!isFound[i])
            {
                index = i;
            }
        }
        Console.WriteLine(numbers[index]);
    }
}