using System;

class Combinations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static int[] arr = new int[k];

    static void Main()
    {
        Combinate(0, 1);
    }

    static void Combinate(int index, int start)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        else
        {
            for (int i = start; i <= n; i++)
            {
                arr[index] = i;
                Combinate(index + 1, i + 1);
            }
        }
    }
}