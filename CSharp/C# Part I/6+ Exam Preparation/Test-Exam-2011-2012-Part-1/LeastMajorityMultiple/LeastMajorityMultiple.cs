using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        byte c = byte.Parse(Console.ReadLine());
        byte d = byte.Parse(Console.ReadLine());
        byte e = byte.Parse(Console.ReadLine());

        for (int i = 1; ; i++)
        {
            byte count = 0;
            if ((i % a) == 0)
            {
                count++;
            }
            if ((i % b) == 0)
            {
                count++;
            }
            if ((i % c) == 0)
            {
                count++;
            }
            if ((i % d) == 0)
            {
                count++;
            }
            if ((i % e) == 0)
            {
                count++;
            }
            if (count > 2)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}