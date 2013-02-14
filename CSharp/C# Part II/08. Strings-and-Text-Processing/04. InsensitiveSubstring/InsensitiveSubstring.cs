using System;

class InsensitiveSubstring
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. 
        We don't have anything else. Inside the submarine is very tight. 
        So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        string target = "in".ToLower();
        int occurences = 0;

        int index = text.IndexOf(target, 0);
        while (index != -1)
        {
            occurences++;
            index = text.IndexOf(target, index + 1);
        }
        Console.WriteLine(occurences);
    }
}