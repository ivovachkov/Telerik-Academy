using System;

class FirstGreaterExchange
{
    static void Main()
    {
        int firstNumber = -5;
        int secondNumber = -20;
        int swapNumber = 0;

        Console.WriteLine("First number is: " + firstNumber);
        Console.WriteLine("Second number is: " + secondNumber);
        Console.WriteLine();

        if (firstNumber > secondNumber)
        {
            swapNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapNumber;
        }
        Console.WriteLine("First number is: " + firstNumber);
        Console.WriteLine("Second number is: " + secondNumber);
        Console.WriteLine();
    }
}
