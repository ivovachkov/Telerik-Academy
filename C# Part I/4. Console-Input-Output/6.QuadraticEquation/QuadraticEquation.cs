using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("There are no real roots!");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("X1=X2= " + x);
        }
        else
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("X1={0}", x1);
            Console.WriteLine("X2={0}", x2);
        }
    }
}