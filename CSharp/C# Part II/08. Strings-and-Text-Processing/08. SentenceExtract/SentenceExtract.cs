using System;
using System.Text;

class SentenceExtract
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. 
We will move out of it in 5 days.";
        StringBuilder result = new StringBuilder();

        string sub = "in";
        string[] sentences = text.Split('.');
        foreach (string sentence in sentences)
        {
            string[] words = sentence.Split(new char[]{' ', ',', '-', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (string.Compare(sub, word, true) == 0)
                {
                    result.Append(sentence + '.');
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}