using System;

class PrimeEratosthenes
{
    static void Main()
    {
        int count = 10000000;
        bool[] prime = new bool[count + 1];
        for (int i = 2; i <= count; i++)
        {
            prime[i] = true;
        }

        for (int number = 2; number <= count; number++)
        {
            if (prime[number])
            {
                Console.Write("{0} ", number);
                for (int i = 2 * number; i <= count; i += number)
                {
                    prime[i] = false;
                }
            }
        }

        Console.WriteLine();
    }
}
