using System;

class FractionSum
{
    static void Main()
    {
        double sum = 1.0;

        for (int i = 2; (1.0 / i) >= 0.001; i++)
        {
            if (i % 2 == 0)
            {
                sum += (1.0 / i);
            }
            else
            {
                sum -= (1.0 / i);
            }
        }
        Console.WriteLine("{0:F3}", sum);
    }
}