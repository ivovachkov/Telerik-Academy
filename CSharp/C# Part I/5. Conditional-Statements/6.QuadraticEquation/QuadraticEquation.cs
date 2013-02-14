using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a = 1;
        double b = 2;
        double c = 1;

        double d = 0;
        d = (b * b) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (d == 0)
        {
            double x = 0;
            x = (-b) / (2 * a * c);
            Console.WriteLine("X1=X2=" + x);
        }
        else
        {
            double x1 = 0;
            double x2 = 0;
            x1 = (-b + Math.Sqrt(d)) / (2 * a * c);
            x2 = (-b - Math.Sqrt(d)) / (2 * a * c);
            Console.WriteLine("X1=" + x1);
            Console.WriteLine("X2=" + x2);
        }
    }
}