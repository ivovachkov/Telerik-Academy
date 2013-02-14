using System;

class ReminderCount
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int number = firstNumber; number <= secondNumber; number++)
        {
            if (number % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}