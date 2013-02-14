using System;
using System.Text;

class SumValues
{
    static void Main()
    {
        string input = Console.ReadLine();
        int result = GetPrintSum(input);
        Console.WriteLine("Sum is: " + result);
    }

    static int GetPrintSum(string input)
    {
        string[] numbers = input.Split(' ');
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = int.Parse(numbers[i]);
            sum += currentNumber;
        }
        return sum;
    }
}