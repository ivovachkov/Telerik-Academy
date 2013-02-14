using System;
using System.Collections.Generic;
using System.Text;

class Crossword
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] crossword = new char[2 * n, n];
        string[] words = new string[2 * n];

        for (int row = 0; row < 2 * n; row++)
        {
            words[row] = Console.ReadLine();
        }

        string[] downWords = new string[n];
        for (int col = 0; col < n; col++)
        {
            StringBuilder word = new StringBuilder();
            for (int row = 0; row < 2 * n; row++)
            {
                word.Append(words[row][col]);
            }
            downWords[col] = word.ToString();
        }

        List<string> result = new List<string>();
        foreach (var downWord in downWords)
        {
            foreach (var word in words)
            {
                if (downWord.Contains(word))
                {
                    result.Add(word);
                }
            }
        }
        Console.WriteLine();
        if (result.Count == 0)
        {
            Console.WriteLine("NO SOLUTION!");
        }
        else
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}