using System;

class NullValues
{
    static void Main()
    {
        int? firstNumber = null;
        double? secondNumber = 5.0005;

        Console.WriteLine("{0}\n{1}", firstNumber, secondNumber);
        Console.WriteLine(firstNumber + secondNumber + 5);
    }
}