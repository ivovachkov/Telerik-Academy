using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binary = "1001011110100111";
        int decimalNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            decimalNumber += (binary[binary.Length - i - 1] - '0') << i;
        }
        Console.WriteLine(decimalNumber);
    }
}