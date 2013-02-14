using System;
using System.Text;

class HexToBinary
{
    static void Main()
    {
        string hex = "AB98CD";
        StringBuilder binary = new StringBuilder();

        for (int i = 0; i < hex.Length; i++)
        {
            char current = hex[i];
            int number = current - '0';
            int letter = current - '7';
            if (number > 9)
            {
                binary.Append(GetBits(letter));
            }
            else
            {
                binary.Append(GetBits(number));
            }
        }
        Console.WriteLine("Convert: {0,31}", binary.ToString());
        Console.WriteLine("Direct convert: " + DirectConversion(hex));
        Console.WriteLine("C# convert: {0,28}", Convert.ToString(0xAB98CD, 2));
    }

    static string GetBits(int number)
    {
        string bits = string.Empty;
        while (number > 0)
        {
            bits = (number & 1) + bits;
            number >>= 1;
        }
        return bits;
    }

    static string DirectConversion(string hex)
    {
        StringBuilder bin = new StringBuilder();

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0':
                    bin.Append("0000");
                    break;
                case '1':
                    bin.Append("0001");
                    break;
                case '2':
                    bin.Append("0010");
                    break;
                case '3':
                    bin.Append("0011");
                    break;
                case '4':
                    bin.Append("0100");
                    break;
                case '5':
                    bin.Append("0101");
                    break;
                case '6':
                    bin.Append("0110");
                    break;
                case '7':
                    bin.Append("0111");
                    break;
                case '8':
                    bin.Append("1000");
                    break;
                case '9':
                    bin.Append("1001");
                    break;
                case 'A':
                    bin.Append("1010");
                    break;
                case 'B':
                    bin.Append("1011");
                    break;
                case 'C':
                    bin.Append("1100");
                    break;
                case 'D':
                    bin.Append("1101");
                    break;
                case 'E':
                    bin.Append("1110");
                    break;
                case 'F':
                    bin.Append("1111");
                    break;
                default:
                    break;
            }
        }

        return bin.ToString();
    }
}