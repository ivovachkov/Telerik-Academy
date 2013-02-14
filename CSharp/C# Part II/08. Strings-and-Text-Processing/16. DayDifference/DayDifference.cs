using System;

class DayDifference
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        DateTime first = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter second date: ");
        DateTime second = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Distance: {0} days", (second-first).Days);
    }
}