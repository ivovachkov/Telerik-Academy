using System;

class Today
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine(today.DayOfWeek);
    }
}