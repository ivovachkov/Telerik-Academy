using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = "sample";
        StringBuilder result = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }
        Console.WriteLine(result.ToString());
    }
}