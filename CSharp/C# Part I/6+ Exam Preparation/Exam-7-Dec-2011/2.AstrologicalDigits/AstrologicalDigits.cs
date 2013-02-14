using System;

class AstrologicalDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        int length = input.Length;
        int sum = 0;

        for (int i = 0; i < length; i++)
        {
            int digit;
            string symbol = input[i].ToString();
            bool isDigit = int.TryParse(symbol, out digit);
            if (isDigit)
            {
                sum += digit;
            }
        }

        while (sum > 9)
        {
            string strSum = sum.ToString();
            sum = 0;
            for (int i = 0; i < strSum.Length; i++)
            {
                int digit = int.Parse(strSum[i].ToString());
                sum += digit;
            }
        }
        Console.WriteLine(sum);
    }
}