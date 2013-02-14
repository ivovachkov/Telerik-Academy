using System;

class BitHold
{
    static void Main()
    {
        int n = 5;
        int p = 2;
        int v = 0;
        int result = (v == 1) ? ((1 << p) | n) : ((~ (1 << p)) & n);
        Console.WriteLine(result);
    }
}