using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hex = "12D0C8";
        Console.WriteLine(0x12D0C8);
                
        int dec = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            char current = hex[hex.Length - i - 1];
            int number = current - '0';
            int letter = current - '7';
            if (number < 10)
            {
                dec += number * (int)Math.Pow(16, i);
            }
            else
            {
                dec += letter * (int)Math.Pow(16, i);
            }
        }
        Console.WriteLine(dec);
    }
}