using System;

class BitInPositionP1
{
    static void Main()
    {
        int v = 567;
        byte p = 5;
        bool result = ((v >> p) & 1) == 1;
        Console.WriteLine(result);
    }
}