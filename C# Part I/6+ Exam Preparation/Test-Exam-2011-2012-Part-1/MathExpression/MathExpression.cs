using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal result = 0.0m;

        result = (n * n + 1/(m * p) + 1337)/(n - 128.523123123m * p) + (decimal)Math.Sin((int)m % 180);
        Console.WriteLine("{0:f6}", result);
    }
}