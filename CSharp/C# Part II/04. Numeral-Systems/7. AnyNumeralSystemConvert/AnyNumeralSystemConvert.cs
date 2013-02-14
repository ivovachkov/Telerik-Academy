using System;

class AnyNumeralSystemConvert
{
    static void Main()
    {
        Console.Write("From = ");
        int from = int.Parse(Console.ReadLine());

        Console.Write("To = ");
        int to = int.Parse(Console.ReadLine());

        Console.Write("Enter number in {0} numeral system: ", from);
        string input = Console.ReadLine().ToUpper();

        string result = string.Empty;

        long decimalNumber = 0;
        int length = input.Length;

        for (int i = 0; i < length; i++)
        {
            char current = input[length - i - 1];
            int number = current - '0';
            int letter = current - '7';
            if (number < 10)
            {
                decimalNumber += number * (int)Math.Pow(from, i);
            }
            else
            {
                decimalNumber += letter * (int)Math.Pow(from, i);
            }
        }
        Console.WriteLine("Decimal representation is: {0}", decimalNumber);

        while (decimalNumber > 0)
        {
            long current = decimalNumber % to;
            char letter = (char)(current + 55);
            if (current > 9)
            {
                result = letter + result;
            }
            else
            {
                result = current + result;
            }
            decimalNumber /= to;
        }

        Console.WriteLine("{0}-Representation is: {1}", to, result);
    }
}