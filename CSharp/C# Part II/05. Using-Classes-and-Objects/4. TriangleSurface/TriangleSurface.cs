using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine(ThreeSidesSurface(5, 6, 8));
        Console.WriteLine(TwoSidesAngle(5, 6, 8));
        Console.WriteLine(TwoSidesAnglesSecond(5, 6, 8));
        Console.WriteLine(SideAltitudeSurface(5, 6));
    }

    static double ThreeSidesSurface(double firstSide, double secondSide, double thirdSide)
    {
        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * 
            (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
    }

    static double TwoSidesAngle(double firstSide, double secondSide, double angle)
    {
        double thirdSide = Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(firstSide, 2) - 
            2 * firstSide * secondSide * Math.Cos(angle));

        return ThreeSidesSurface(firstSide, secondSide, thirdSide);
    }

    static double TwoSidesAnglesSecond(double firstSide, double secondSide, double angle)
    {
        return firstSide * secondSide * Math.Sin(angle) / 2;
    }

    static double SideAltitudeSurface(double side, double altitude)
    {
        return side * altitude / 2;
    }
}