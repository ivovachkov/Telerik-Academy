using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<string> result = new List<string>();
        if (number == 0)
        {
            Console.WriteLine('A');
        }
        else
        {
            while (number > 0)
            {
                ulong remainder = number % 256;
                result.Add(BaseNumber(remainder));
                number /= 256;
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }

    static string BaseNumber(ulong number)
    {
        string result = string.Empty;

        if (number >= 0 && number < 26)
        {
            result = ((char)('A' + number)).ToString();
        }
        else if (number >= 26 && number < 256)
        {
            ulong whole = number / 26;
            ulong remainder = number % 26;
            string first = ((char)(96 + whole)).ToString();
            string second = ((char)('A' + remainder)).ToString();
            result = first + second;
        }
        return result;
    }
}