using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = new int[]{ 4, 1, 1, 2, 3, 1, 2, 9, 3 };
        int length = arr.Length;
        bool[] found = new bool[length];
        int mostFreq = 0;
        int number = Int32.MinValue;

        for (int i = 0; i < length - 1; i++)
        {
            if (!found[i])
            {
                int freq = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        freq++;
                        found[j] = true;
                    }
                }
                if (freq > mostFreq)
                {
                    mostFreq = freq;
                    number = arr[i];
                }
            }
        }

        if (length == 0 || mostFreq == 1)
        {
            Console.WriteLine("There is no most frequent number!!!");
        }
        else
        {
            Console.WriteLine("The most frequent number is: " + number);
            Console.WriteLine("Found " + mostFreq + " times.");
        }
    }
}