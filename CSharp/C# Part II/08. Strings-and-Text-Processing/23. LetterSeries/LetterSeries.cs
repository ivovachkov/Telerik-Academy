using System;
using System.Text;

class LetterSeries
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();

        char current = input[0];
        result.Append(current);
        for (int i = 1; i < input.Length; i++)
        {
            if (current != input[i])
            {
                current = input[i];
                result.Append(current);
            }
        }
        Console.WriteLine(result.ToString());
    }
}