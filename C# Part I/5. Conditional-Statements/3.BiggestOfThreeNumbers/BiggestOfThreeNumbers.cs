using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        int firstNumber = -3;
        int secondNumber = 0;
        int thirdNumber = 255;
        int biggestNumber = 0;

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                biggestNumber = firstNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                biggestNumber = secondNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}
