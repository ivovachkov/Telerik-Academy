using System;

class GuitarRecursive
{
    static int end;
    static int[] numbers;
    static int max = -1;

    static void Main()
    {
        string line = Console.ReadLine();
        string[] tokens = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int length = tokens.Length;
        numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(tokens[i]);
        }

        int start = int.Parse(Console.ReadLine());
        end = int.Parse(Console.ReadLine());

        FindMax(0, start);
        Console.WriteLine(max);
    }

    static void FindMax(int index, int current)
    {
        if (index >= numbers.Length)
        {
            if (current > max)
            {
                max = current;
            }
            return;
        }
        if (current + numbers[index] <= end)
        {
            FindMax(index + 1, current + numbers[index]);
        }
        if (current - numbers[index] >= 0)
        {
            FindMax(index + 1, current - numbers[index]);
        }
    }
}