using System;

class ExchangeValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        Console.WriteLine("firstValue is: {0}, secondValue is: {1}", firstValue, secondValue);

        int thirdValue = firstValue;
        firstValue = secondValue;
        secondValue = thirdValue;
        Console.WriteLine("firstValue is: {0}, secondValue is: {1}", firstValue, secondValue);

        //firstValue = firstValue + secondValue;
        //secondValue = firstValue - secondValue;
        //firstValue = firstValue - secondValue;
        //Console.WriteLine("firstValue is: {0}, secondValue is: {1}", firstValue, secondValue);
    }
}