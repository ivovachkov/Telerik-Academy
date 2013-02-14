using System;

class MaxOfTwo
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine("Max number is: " + GetMax(GetMax(first,second), third));
    }

    static int GetMax(int first, int second)
    {
        int max = first;
        if (second > max)
        {
            max = second;
        }
        return max;
    }
}