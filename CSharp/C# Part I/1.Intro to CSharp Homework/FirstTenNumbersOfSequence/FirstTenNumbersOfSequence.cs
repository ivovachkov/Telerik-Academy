using System;

class FirstTenNumbersOfSequence
{
    static void Main()
    {
        for (int i = 2, j = -3; i < 11; i += 2, j -= 2)
        {
            Console.Write("{0} {1} ", i, j);
        }
        Console.WriteLine();
    }
}