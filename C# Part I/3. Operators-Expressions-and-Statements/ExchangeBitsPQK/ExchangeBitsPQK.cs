using System;

class ExchangeBitsPQK
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary is: " + Convert.ToString(number, 2).PadLeft(32, '0'));

        int p = 5;
        int q = 15;
        int k = 6;

        for (int i = 0; i <= k - 1; i++)
        {
            if ((number & (1 << p)) != (number & (1 << q)))
            {
                number = (uint)(number ^ (1 << p));
                number = (uint)(number ^ (1 << q));
            }
            p++;
            q++;
        }
        Console.WriteLine("The new number is: " + number);
        Console.WriteLine("The new number in binary is: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}