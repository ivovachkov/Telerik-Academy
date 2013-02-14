using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        long number = -6234234212312321;
        string binary = string.Empty;

        for (int i = 63; i >= 0; i--)
        {
            binary = ((number) & 1) + binary;
            number >>= 1;
        }
        Console.WriteLine(binary);
    }
}