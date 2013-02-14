using System;
using System.Globalization;
using System.Threading;

class DatesExtract
{
    static void Main()
    {
        string text = "the time goes by 03.12.2005, 50.30.2012,  12.12.2000, 03/03/2001, 09-10-1999";
        string[] tokens = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        DateTime date;
        foreach (var token in tokens)
        {
            if (DateTime.TryParseExact(token, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                Console.WriteLine(date);
            }
        }

    }
}