using System;
using System.Text;

class CopyrightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char a = '\u00A9';

        Console.WriteLine("    " + a);
        Console.WriteLine("   " + a + " " + a);
        Console.WriteLine("  " + a + "   " + a);
        Console.WriteLine(" " + a + " " + a + " " + a + " " + a);
    }
}