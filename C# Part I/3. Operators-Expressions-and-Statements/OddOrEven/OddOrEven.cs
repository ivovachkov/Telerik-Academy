using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine(result);
    }
}