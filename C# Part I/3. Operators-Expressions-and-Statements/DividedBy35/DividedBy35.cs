using System;

class DividedBy35
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        bool check = (number % 35 == 0);
        Console.WriteLine(check);
    }
}