using System;

class FighterAtack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        fx = fx + d;
        int minPX = Math.Min(px1, px2);
        int maxPX = Math.Max(px1, px2);
        int minPY = Math.Min(py1, py2);
        int maxPY = Math.Max(py1, py2);
        short damage = 0;

        if ((fx >= minPX) && (fx <= maxPX) && (fy >= minPY) && (fy <= maxPY))
        {
            damage += 100;
        }
        if (((fx + 1) >= minPX) && ((fx + 1) <= maxPX) && (fy >= minPY) && (fy <= maxPY))
        {
            damage += 75;
        }
        if ((fx >= minPX) && (fx <= maxPX) && ((fy + 1) >= minPY) && ((fy + 1) <= maxPY))
        {
            damage += 50;
        }
        if ((fx >= minPX) && (fx <= maxPX) && ((fy - 1) >= minPY) && ((fy - 1) <= maxPY))
        {
            damage += 50;
        }
        Console.WriteLine(damage + "%");
    }
}