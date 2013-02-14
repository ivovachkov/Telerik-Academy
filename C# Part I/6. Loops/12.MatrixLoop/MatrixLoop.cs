using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number between 1 and 20: ");
        int n = int.Parse(Console.ReadLine());

        if ((n > 20) || (n <= 0))
        {
            Console.WriteLine("Incorect number!");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0,-3}", i + j - 1);
            }
            Console.WriteLine();

        }
    }
}