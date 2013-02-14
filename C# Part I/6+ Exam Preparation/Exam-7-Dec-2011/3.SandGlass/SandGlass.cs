using System;

class SandGlass
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string stars = new string('*', n);
        Console.WriteLine(stars);

        for (byte i = 1; i <= (n - 3) / 2; i++)
        {
            string dotsIn = new string('.', i);
            Console.Write(dotsIn);
            string starsIn = new string('*', n - 2 * i);
            Console.Write(starsIn);
            Console.WriteLine(dotsIn);
        }

        string dots = new string('.', (n - 1) / 2);
        Console.Write(dots);
        Console.Write("*");
        Console.WriteLine(dots);

        for (byte i = (byte)((n - 3) / 2); i >= 1; i--)
        {
            string dotsIn = new string('.', i);
            Console.Write(dotsIn);
            string starsIn = new string('*', n - 2*i);
            Console.Write(starsIn);
            Console.WriteLine(dotsIn);
        }

        Console.WriteLine(stars);
    }
}