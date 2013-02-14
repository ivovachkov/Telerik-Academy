using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            int result = 0;
            for (int j = 0; j < 32; j++)
            {
                if ((((1 << j) & number) != 0) && (b == 1))
                {
                    result++;
                }
                if ((((1 << j) & number) == 0) && (b == 0) && ((number >> j) != 0))
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}