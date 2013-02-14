using System;
using System.Text;

class BinaryToHex
{
    static void Main()
    {
        string binary = "10100010101110";

        //adding '0' to the left part so it can be in groups of four
        int length = binary.Length;
        int add = length % 4;
        add = (4 - add);
        binary = binary.PadLeft(length + add, '0');

        string result = DirectConvert(binary);        
        Console.WriteLine(result);
    }

    static string DirectConvert(string binary)
    {
        StringBuilder hex = new StringBuilder();

        for (int i = 0; i < binary.Length; i+=4)
        {
            string bits = binary.Substring(i, 4);

            switch (bits)
            {
                case "0000":
                    hex.Append(0);
                    break;
                case "0001":
                    hex.Append(1);
                    break;
                case "0010":
                    hex.Append(2);
                    break;
                case "0011":
                    hex.Append(3);
                    break;
                case "0100":
                    hex.Append(4);
                    break;
                case "0101":
                    hex.Append(5);
                    break;
                case "0110":
                    hex.Append(6);
                    break;
                case "0111":
                    hex.Append(7);
                    break;
                case "1000":
                    hex.Append(8);
                    break;
                case "1001":
                    hex.Append(9);
                    break;
                case "1010":
                    hex.Append('A');
                    break;
                case "1011":
                    hex.Append('B');
                    break;
                case "1100":
                    hex.Append('C');
                    break;
                case "1101":
                    hex.Append('D');
                    break;
                case "1110":
                    hex.Append('E');
                    break;
                case "1111":
                    hex.Append('F');
                    break;
                default:
                    break;
            }
        }

        return hex.ToString();
    }
}