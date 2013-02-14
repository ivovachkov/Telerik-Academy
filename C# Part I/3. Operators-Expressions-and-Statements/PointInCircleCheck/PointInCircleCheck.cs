using System;

class PointInCircleCheck
{
    static void Main()
    {
        double x = 0.1;
        double y = -2.7;
        bool result = Math.Sqrt(x*x + y*y)<=5.0;
        Console.WriteLine(result);
    }
}