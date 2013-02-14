using System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        string text = "alabala, ABBA data. goes by do exe php lamel lamal pascal csharp phpfog";
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindrom = new List<string>();

        foreach (var word in words)
        {
            bool isSymetric = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                palindrom.Add(word);
            }
        }
        Console.WriteLine(string.Join(" ", palindrom));
    }
}