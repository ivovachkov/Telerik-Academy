using System;

class Asterisks
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length > 20)
        {
            Console.WriteLine("The string is too long");
        }
        else
        {
            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}