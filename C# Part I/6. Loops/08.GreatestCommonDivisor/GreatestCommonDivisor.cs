using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int firstNumber = 784;
        int secondNumber = 240;

        while (secondNumber != 0)
        {
            int tempNumber = secondNumber; 
            secondNumber = firstNumber % secondNumber;
            firstNumber = tempNumber;
        }
        Console.WriteLine(firstNumber);
    }
}