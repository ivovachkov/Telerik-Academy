using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        int length = tokens.Length;
        int[] valley = new int[length];
        int max = int.MinValue;

        for (int i = 0; i < length; i++)
        {
            valley[i] = int.Parse(tokens[i]);
        }

        int patternCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < patternCount; i++)
        {
            bool[] visited = new bool[length];
            input = Console.ReadLine();
            tokens = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[tokens.Length];
            for (int j = 0; j < pattern.Length; j++)
            {
                pattern[j] = int.Parse(tokens[j]);
            }

            int index = 0;
            int currentSum = 0;
            int pIndex = 0;
 
            while (index >= 0 && index < valley.Length)
            {
                if (!visited[index])
                {
                    currentSum += valley[index];
                    visited[index] = true;
                    index += pattern[pIndex];
                    pIndex++;

                    if (pIndex == pattern.Length)
                    {
                        pIndex = 0;
                    }
                }
                else
                {
                    break;
                }
            }

            if (currentSum > max)
            {
                max = currentSum;
            }
        }
        Console.WriteLine(max);
    }
}