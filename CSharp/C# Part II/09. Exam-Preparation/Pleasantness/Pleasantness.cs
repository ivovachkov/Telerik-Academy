using System;

class Pleasantness
{
    static void Main()
    {
        string line = Console.ReadLine();
        int variety = int.Parse(Console.ReadLine());

        string[] tokens = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int length = tokens.Length;
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(tokens[i]);
        }

        int index = 0;
        int min = numbers[0];
        int max = numbers[0];
        int minIndex = 0;
        int maxIndex = 0;
        int currentVariety = 0;

        for (int i = 1; i < length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                minIndex = i;
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }

            currentVariety = max - min;

            if (currentVariety >= variety)
            {
                index = i;
                break;
            }
        }

        if (index > 0)
        {
            if (Math.Abs(maxIndex - minIndex) % 2 == 0 || index % 2 != 0)
            {
                Console.WriteLine((index + 1) / 2 + 1);
            }
            else
            {
                Console.WriteLine((index + 1) / 2 + 2);
            }            
        }
        else
        {
            Console.WriteLine(length);
        }
    }
}