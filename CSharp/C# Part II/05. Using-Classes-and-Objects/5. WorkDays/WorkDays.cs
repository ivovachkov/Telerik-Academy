using System;

class WorkDays
{
    static DateTime[] holidays = { new DateTime(2013, 2, 4), new DateTime(2013, 3, 6) };

    static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime end = new DateTime(2013, 2, 10);
        int result = CalcWorkDays(today, end);
        Console.WriteLine(result);
    }

    static int CalcWorkDays(DateTime today, DateTime end)
    {
        int result = 0;
        while (today.Date < end.Date)
        {
            today = today.AddDays(1);
            if ((today.DayOfWeek != DayOfWeek.Saturday) && 
                (today.DayOfWeek != DayOfWeek.Sunday) &&
                !(IsHoliday(today)))
            {
                result++;
            }
        }
        
        return result;
    }

    static bool IsHoliday(DateTime date)
    {
        for (int i = 0; i < holidays.Length; i++)
        {
            if (date.Date == holidays[i].Date)
            {
                return true;
            }
        }
        return false;
    }
}