using System;

class SumThreeNum
{
    static void Main()
    {
        int sum = 0;
        int num = 0;
        for (int i = 0; i < 3; i++)
        {
            num = Int32.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
