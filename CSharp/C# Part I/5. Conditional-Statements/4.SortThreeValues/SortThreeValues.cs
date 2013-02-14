using System;

class SortThreeValues
{
    static void Main()
    {
        double firstValue = -23;
        double secondValue = 9.45;
        double thirdValue = 0;
        double minValue = 0;
        double maxValue = 0;
        double midValue = 0;

        if (firstValue > secondValue)
        {
            if (firstValue > thirdValue)
            {
                maxValue = firstValue;
                if (secondValue > thirdValue)
                {
                    minValue = thirdValue;
                    midValue = secondValue;
                }
                else
                {
                    minValue = secondValue;
                    midValue = thirdValue;
                }
            }
            else
            {
                minValue = secondValue;
                midValue = firstValue;
                maxValue = thirdValue;
            }
        }
        else
        {
            if (secondValue > thirdValue)
            {
                maxValue = secondValue;
                if (firstValue > thirdValue)
                {
                    minValue = thirdValue;
                    midValue = firstValue;
                }
                else
                {
                    minValue = firstValue;
                    midValue = thirdValue;
                }
            }
            else
            {
                minValue = firstValue;
                midValue = secondValue;
                maxValue = thirdValue;
            }
        }
        Console.WriteLine(minValue);
        Console.WriteLine(midValue);
        Console.WriteLine(maxValue);
    }
}