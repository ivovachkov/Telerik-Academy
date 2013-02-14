using System;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        short number = 32567;
        StringBuilder result = new StringBuilder();
                
        for (int i = 15; i >= 0; i--)
        {
            result.Append((number >> i) & 1);
        }
        Console.WriteLine(result.ToString());
    }
}