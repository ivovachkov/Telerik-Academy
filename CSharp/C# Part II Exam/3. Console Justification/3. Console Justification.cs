using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in tokens)
            {
                words.Add(item);
            }
        }

        int index = 0;

        while (index < words.Count)
        {
            int length = 0;
            List<string> lineWords = new List<string>();

            while (index < words.Count)
            {
                lineWords.Add(words[index]);
                length += words[index].Length + 1;
                index++;

                if (length > w + 1)
                {
                    lineWords.RemoveAt(lineWords.Count - 1);
                    length -= words[index - 1].Length + 1;
                    length -= lineWords.Count;
                    index--;
                    break;
                }
            }

            if (index >= words.Count)
            {
                length -= lineWords.Count;
            }

            if (lineWords.Count > 1)
            {
                int space = (w - length) / (lineWords.Count - 1);
                int extraSpace = (w - length) % (lineWords.Count - 1);

                int extra = 0;
                for (int i = 0; i < lineWords.Count - 1; i++)
                {
                    result.Append(lineWords[i]);
                    if (extra < extraSpace)
                    {
                        result.Append(' ');
                        extra++;
                    }
                    result.Append(new string(' ', space));
                }
            }
            result.AppendLine(lineWords[lineWords.Count - 1]);
        }

        Console.WriteLine(result);
    }
}