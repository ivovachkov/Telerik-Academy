using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        int n = 42;
        for (int number = 1; number <= n; number++)
        {
            if ((number % 21) != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}