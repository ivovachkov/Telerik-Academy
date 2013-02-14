using System;
using System.Text;

class UnicodeLiterals
{
    static void Main()
    {
        string input = "Hi!";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            result.Append(string.Format("\\u{0:X4}", (int)(input[i])));
        }
        Console.WriteLine(result.ToString());
    }
}