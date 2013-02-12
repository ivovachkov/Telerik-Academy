using System;

class UseOfQuotations
{
    static void Main()
    {
        string firstString = @"The ""use"" of quotations causes difficulties.";
        string secondString = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}", firstString, secondString);
    }
}