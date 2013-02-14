using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] votes = new int[n];
        int[] cats = new int[10];

        for (int i = 0; i < votes.Length; i++)
        {
            votes[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < votes.Length; i++)
        {
            cats[votes[i] - 1]++;
        }

        int missCat = 0;
        for (int j = 1; j < 10; j++)
        {
            if (cats[j] > cats[missCat])
            {
                missCat = j;
            }
        }
        Console.WriteLine(missCat + 1);
    }
}