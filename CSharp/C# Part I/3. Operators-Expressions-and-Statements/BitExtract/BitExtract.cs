using System;

class BitExtract
{
    static void Main()
    {
        int i = 5567; 
        int b = 7;
        int bitExtractValue = (i >> b) & 1;
        Console.WriteLine(bitExtractValue);
    }
}