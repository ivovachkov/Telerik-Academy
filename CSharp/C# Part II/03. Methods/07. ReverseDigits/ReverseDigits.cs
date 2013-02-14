using System;

class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine(Reverse(23235));
    }

    static int Reverse(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed += number % 10;
            number /= 10;
            reversed *= 10;
        }
        return reversed / 10;
    }
}