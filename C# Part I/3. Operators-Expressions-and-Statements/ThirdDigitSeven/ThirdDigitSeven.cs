using System;

class ThirdDigitSeven
{
    static void Main()
    {
        int number = 135435732;
        bool result = (number / 100) % 10 == 7;
        Console.WriteLine(result);
    }
}