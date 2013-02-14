using System;
using System.Threading;
using System.Globalization;

class BulgarianDay
{
    static void Main()
    {
        string input = "31.12.2013 23:59:59";
        DateTime date = DateTime.Parse(input);
        date = date.AddHours(6.5);

        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine(date.ToString("dd MMMM yyyy H:mm:ss (dddd)"));
    }
}