using System;

class ThirdBitCheck
{
    static void Main()
    {
        int number = 45065;
        bool check = (number & 8) == 8;
        int result = check ? 1 : 0;
        Console.WriteLine(result);
    }
}