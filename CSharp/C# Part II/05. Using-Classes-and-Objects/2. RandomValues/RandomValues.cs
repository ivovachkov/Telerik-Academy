using System;

class RandomValues
{
    static Random rand = new Random();

    static void Main()
    {
        for (int i = 0; i < 30; i++)
        {
            int number = rand.Next(100, 201);
            Console.WriteLine(number);
        }
    }
}