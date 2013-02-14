using System;

class FloatingPointBinary
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        Console.WriteLine("Sign = {0}", GetSign(number));
        Console.WriteLine("Exponent = {0}", GetExponent(number));
        Console.WriteLine("Mantissa = {0}", GetMantissa(number));
    }

    static string GetSign(float number)
    {
        if (number >= 0)
        {
            return "0";
        }
        else
        {
            return "1";
        }
    }

    static string GetExponent(float number)
    {
        int wholePart = (int)number;
        if (number < 0)
        {
            wholePart *= -1;
        }
        else if (number == 0)
        {
            return "00000000";
        }

        byte exponent = 0;

        while (wholePart > 1)
        {
            wholePart >>= 1;
            exponent++;
        }
        exponent = (byte)(exponent + 127);

        return Convert.ToString(exponent, 2).PadLeft(8, '0');
    }

    static string GetMantissa(float number)
    {
        string mantissa = String.Empty;

        int wholePart = (int)number;
        if (number < 0)
        {
            wholePart *= -1;
            number *= -1;
        }

        float fraction = number - wholePart;

        while (wholePart > 1)
        {
            mantissa += wholePart & 1;
            wholePart >>= 1;
        }
        mantissa = ReverseString(mantissa);
        mantissa += 0;

        while (fraction > 0)
        {
            fraction = (fraction * 2) - (int)(fraction * 2);
            mantissa += (int)(fraction * 2);
        }

        return mantissa.PadRight(23, '0');
    }

    static string ReverseString(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }
}