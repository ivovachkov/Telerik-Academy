using System;

class ReadNumberInRange
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(1, 100);
        }
        
    }

    static void ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter number between {0} and {1}", start, end);
        Exception e = new Exception("The number is not in the boundries asked!");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw e;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}