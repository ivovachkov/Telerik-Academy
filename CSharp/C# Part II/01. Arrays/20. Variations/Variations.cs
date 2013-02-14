using System;

class Variations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static int[] arr = new int[k];

    static void Main()
    {
        Variate(0);
    }

    static void Variate(int index)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                Variate(index + 1);
            }
        }
    }
}