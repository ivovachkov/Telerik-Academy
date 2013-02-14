using System;

class CharArraysComparison
{
    static void Main()
    {
        char[] firstCharArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
        char[] secondCharArray = { 'c', 'm', 'a', 'f', 'j', 'l' };

        for (int i = 0; i < firstCharArray.Length; i++)
        {
            for (int j = 0; j < secondCharArray.Length; j++)
            {
                if (firstCharArray[i] == secondCharArray[j])
                {
                    Console.Write(firstCharArray[i] + " ");
                }
            }
        }
        Console.WriteLine();
    }
}