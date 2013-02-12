using System;

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 128; i++)
        {
            char ch = (char)i;
            string symbol;
            symbol = ch.ToString();
            Console.WriteLine(symbol);
        }
    }
}