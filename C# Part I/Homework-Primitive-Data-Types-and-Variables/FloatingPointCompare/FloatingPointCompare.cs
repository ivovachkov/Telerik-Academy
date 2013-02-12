using System;

class FloatingPointCompare
{
    static void Main()
    {
        //double firstNumber = 1.23456789012345678d;
        //double secondNumber = 1.234567890123456789d;

        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = Math.Abs(firstNumber - secondNumber);

        Console.WriteLine(thirdNumber);

        bool isEqual = thirdNumber == 0;
        Console.WriteLine(isEqual);
    }
}