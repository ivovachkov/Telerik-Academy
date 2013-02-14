using System;

class PrintNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int number = 1; number <= n; number++)
        {
            Console.Write(number);
            if (number != n)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}