using System;

class NumberFormat
{
    static void Main()
    {
        var number = 154465.232323;
        Console.WriteLine("{0,15}", number);
        Console.WriteLine("{0,15:X}", (int)number);
        Console.WriteLine("{0,15:E}", number);
        Console.WriteLine("{0,15:P}", number);
    }
}