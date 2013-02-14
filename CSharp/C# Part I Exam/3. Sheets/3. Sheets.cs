using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            if (((number >> i) & 1) == 0)
            {
                Console.WriteLine("A{0}", 10 - i);
            }
        }

    }
}