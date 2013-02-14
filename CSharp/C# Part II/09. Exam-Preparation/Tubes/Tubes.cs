using System;

class Tubes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[] tubes = new int[n];
        long sum = 0;

        for (int i = 0; i < n; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());
            sum += tubes[i];
        }

        long down = 0;
        long up = sum / m;

        if (up == 0)
        {
            Console.WriteLine(-1);
            return;
        }

        while (down <= up)
        {
            long mid = (down + up) / 2;
            long result = 0;

            for (int i = 0; i < tubes.Length; i++)
            {
                result += tubes[i] / mid;
            }

            if (result >= m)
            {
                down = mid + 1;
            }
            else
            {
                up = mid - 1;
            }

        }

        Console.WriteLine(up);
    }
}