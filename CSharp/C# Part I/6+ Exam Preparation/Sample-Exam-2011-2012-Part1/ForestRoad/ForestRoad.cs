using System;

class ForestRoad
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string dotsBefore = new string('.', i);
            string dotsAfter = new string('.', n - i - 1);
            Console.Write(dotsBefore);
            Console.Write("*");
            Console.WriteLine(dotsAfter);
        }

        for (int j = 1; j < n; j++)
        {
            string dotsBefore = new string('.', n - j - 1);
            string dotsAfter = new string('.', j);
            Console.Write(dotsBefore);
            Console.Write("*");
            Console.WriteLine(dotsAfter);
        }
    }
}