using System;
using System.Collections.Generic;

class WordOccurencesNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', '.', ',', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> occurences = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (occurences.ContainsKey(words[i]))
            {
                occurences[words[i]]++;
            }
            else
            {
                occurences.Add(words[i], 1);
            }
        }

        foreach (var word in occurences)
        {
            Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
        }
    }
}