using System;

class PrimeNumber
{
    static void Main()
    {
        int number = 0;
        bool prime = (number == 2) || (number % 2 != 0) && (number % 3 != 0) 
                    && (number % 5 != 0) && (number % 7 != 0);
        Console.WriteLine(prime);
    }
}