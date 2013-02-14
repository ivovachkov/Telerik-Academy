using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        int number = 2343234;
        Console.WriteLine("{0:X}", number);
        string hex = string.Empty;

        while (number > 0)
        {
            int remainder = number % 16;
            if (remainder > 9)
            {
                hex = (char)(remainder + 55) + hex;
            }
            else
            {
                hex = remainder + hex;
            }
            number /= 16;
        }
        Console.WriteLine(hex);
    }
}