using System;

class PointInCircleOutRect
{
    static void Main()
    {
        double x = -1.1;
        double y = 0.5;
        bool result = (Math.Sqrt((x-1) * (x-1) + (y-1) * (y-1)) <= 3.0)
                        && ((x > 5) || (x < -1) || (y > 1) || (y < -1));
        Console.WriteLine(result);
    }
}