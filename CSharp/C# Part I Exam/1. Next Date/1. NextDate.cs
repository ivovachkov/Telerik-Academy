using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(year, month, day);
        //Console.WriteLine("{0:d.M.yyyy}", date);
        
        DateTime next = date.AddDays(1.0);
        
        Console.WriteLine("{0:d.M.yyyy}", next);
    }
}