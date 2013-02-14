using System;

class GreatestOfFive
{
    static void Main()
    {
        double firstValue = -2.5699;
        double secondValue = 0;
        double thirdValue = -2.569;
        double fourthValue = 5;
        double fifthValue = -248569.569;
        
        double maxValue = firstValue;

        if (secondValue > maxValue)
        {
            maxValue = secondValue;
        }
        if (thirdValue > maxValue)
        {
            maxValue = thirdValue;
        }
        if (fourthValue > maxValue)
        {
            maxValue = fourthValue;
        }
        if (fifthValue > maxValue)
        {
            maxValue = fifthValue;
        }
        Console.WriteLine(maxValue);
    }
}