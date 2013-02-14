using System;

class Trapezoid
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string dots = new string('.', n);
        string stars = new string('*', n);
        Console.WriteLine(dots + stars);

        for (int i = 1; i < n; i++)
        {
            string dotsIn = new string('.', n - i);
            string dotsInSecond = new string('.', n + i - 2);
            Console.Write(dotsIn);
            Console.Write("*");
            Console.Write(dotsInSecond);
            Console.WriteLine("*");
        }

        string starsBottom = new string('*', 2*n);
        Console.WriteLine(starsBottom);
    }
}