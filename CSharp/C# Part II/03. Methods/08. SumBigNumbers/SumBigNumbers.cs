using System;
using System.Text;

class SumBigNumbers
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        Console.WriteLine();

        int n = Math.Max(first.Length, second.Length);

        first = first.PadLeft(n, '0');
        second = second.PadLeft(n, '0');

        Console.WriteLine(first);
        Console.WriteLine(second);

        Console.WriteLine();

        byte[] firstNumber = new byte[n];
        byte[] secondNumber = new byte[n];

        for (int i = 0; i < n; i++)
        {
            firstNumber[i] = (byte)(first[i] - '0');
            secondNumber[i] = (byte)(second[i] - '0');
        }

        string result = SumNumbers(firstNumber, secondNumber, n);

        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    static string SumNumbers(byte[] firstNumber, byte[] secondNumber, int n)
    {
        bool carry = false;

        Array.Reverse(firstNumber);
        Array.Reverse(secondNumber);

        StringBuilder result = new StringBuilder(n);

        for (int i = 0; i < n; i++)
        {
            byte sum = (byte)(firstNumber[i] + secondNumber[i]);
            if (carry)
            {
                sum++;
            }
            if (sum > 9)
            {
                carry = true;
                sum = (byte)(sum % 10);
            }
            else
            {
                carry = false;
            }
            result.Append(sum);
        }

        if (carry)
        {
            result.Append(1);
        }

        return result.ToString();
    }
}