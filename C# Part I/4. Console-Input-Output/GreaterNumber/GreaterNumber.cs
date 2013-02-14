using System;

class ReminderCount
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((firstNumber > secondNumber) ? firstNumber : secondNumber);
        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}