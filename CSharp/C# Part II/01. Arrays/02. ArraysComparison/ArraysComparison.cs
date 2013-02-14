using System;

class ArraysComparison
{
    static void Main()
    {
        int n = 5;
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        Console.WriteLine("Enter first array values: ");
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Enter second array values: ");
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < firstArray.Length; i++)
        {
            for (int j = 0; j < secondArray.Length; j++)
            {
                if (firstArray[i] == secondArray[j])
                {
                    Console.WriteLine(firstArray[i]);
                }
            }
        }
    }
}