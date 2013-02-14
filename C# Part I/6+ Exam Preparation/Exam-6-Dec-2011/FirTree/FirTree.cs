using System;

class FirTree
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string dots = new string('.', n - 2);
        string stars = new string('*', 2*n - 3);

        Console.WriteLine(dots + "*" + dots);

        for (int i = 4; i <= n; i++)
        {
            string inDots = new string('.', n - i + 1);
            string inStars = new string('*', 2 * i - 5);
            Console.Write(inDots);
            Console.Write(inStars);
            Console.WriteLine(inDots);
        }

        Console.WriteLine(stars);
        Console.WriteLine(dots + "*" + dots);
    }
}