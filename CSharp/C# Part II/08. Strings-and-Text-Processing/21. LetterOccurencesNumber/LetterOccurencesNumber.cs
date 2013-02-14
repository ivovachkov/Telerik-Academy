using System;
using System.Collections.Generic;

class LetterOccurencesNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<char, int> occurences = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                if (occurences.ContainsKey(input[i]))
                {
                    occurences[input[i]]++;
                }
                else
                {
                    occurences.Add(input[i], 1);
                }
            }
        }

        foreach (var word in occurences)
        {
            Console.WriteLine("{0} - {1} times", word.Key, word.Value);
        }
    }
}