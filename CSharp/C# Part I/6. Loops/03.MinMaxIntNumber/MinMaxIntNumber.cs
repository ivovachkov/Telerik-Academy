using System;

class MinMaxIntNumber
{
    static void Main()
    {
        int minNumber = 0;
        int maxNumber = 0;
        int n = 5;
        for (int counter = 1; counter <= n; counter++)
        {
            int number = int.Parse(Console.ReadLine());
            if (counter == 1)
            {
                minNumber = number;
                maxNumber = number;
            }
            if (minNumber > number)
            {
                minNumber = number;
            }
            if (maxNumber < number)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine("min={0}, max={1}", minNumber, maxNumber);
    }
}