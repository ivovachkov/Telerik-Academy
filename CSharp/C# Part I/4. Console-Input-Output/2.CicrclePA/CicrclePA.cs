using System;

class CicrclePA
{
    static void Main()
    {

        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter of the circle is: " + 2*Math.PI*r);
        Console.WriteLine("The area of the circle is: " + Math.PI*r*r);
    }
}