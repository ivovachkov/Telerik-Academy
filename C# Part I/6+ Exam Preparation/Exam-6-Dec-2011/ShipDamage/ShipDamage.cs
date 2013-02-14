using System;

class ShipDamage
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());

        int damage = 0;

        cy1 = 2 * h - cy1;
        cy2 = 2 * h - cy2;
        cy3 = 2 * h - cy3;

        int minSX = Math.Min(sx1, sx2);
        int maxSX = Math.Max(sx1, sx2);
        int minSY = Math.Min(sy1, sy2);
        int maxSY = Math.Max(sy1, sy2);

        // C1 damage
        if ((cx1 > minSX) && (cx1 < maxSX) && (cy1 > minSY) && (cy1 < maxSY))
        {
            damage += 100;
        }
        if (((cx1 == sx1) || (cx1 == sx2)) && ((cy1 == sy1) || (cy1 == sy2)))
        {
            damage += 25;
        }
        if ((((cx1 == sx1) || (cx1 == sx2)) && (cy1 > minSY) && (cy1 < maxSY)) ||
            ((cx1 > minSX) && (cx1 < maxSX) && ((cy1 == sy1) || (cy1 == sy2))))
        {
            damage += 50;
        }

        // C2 damage
        if ((cx2 > minSX) && (cx2 < maxSX) && (cy2 > minSY) && (cy2 < maxSY))
        {
            damage += 100;
        }
        if (((cx2 == sx1) || (cx2 == sx2)) && ((cy2 == sy1) || (cy2 == sy2)))
        {
            damage += 25;
        }
        if ((((cx2 == sx1) || (cx2 == sx2)) && (cy2 > minSY) && (cy2 < maxSY)) ||
            ((cx2 > minSX) && (cx2 < maxSX) && ((cy2 == sy1) || (cy2 == sy2))))
        {
            damage += 50;
        }

        // C3 damage
        if ((cx3 > minSX) && (cx3 < maxSX) && (cy3 > minSY) && (cy3 < maxSY))
        {
            damage += 100;
        }
        if (((cx3 == sx1) || (cx3 == sx2)) && ((cy3 == sy1) || (cy3 == sy2)))
        {
            damage += 25;
        }
        if ((((cx3 == sx1) || (cx3 == sx2)) && (cy3 > minSY) && (cy3 < maxSY)) ||
            ((cx3 > minSX) && (cx3 < maxSX) && ((cy3 == sy1) || (cy3 == sy2))))
        {
            damage += 50;
        }

        Console.WriteLine(damage + "%");
    }
}