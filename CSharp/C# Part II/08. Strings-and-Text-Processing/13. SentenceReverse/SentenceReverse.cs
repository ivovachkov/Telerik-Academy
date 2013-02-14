using System;
using System.Text;

class SentenceReverse
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] words = sentence.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        StringBuilder result = new StringBuilder(words[0]);

        int index = 1;
        for (int i = 0; i < sentence.Length; i++)
        {

            char ch = sentence[i];
            if (ch == ',' || ch == '!')
            {
                result.Append(ch);
            }
            else if (ch == ' ')
            {
                result.Append(ch);
                if (index < words.Length)
                {
                    result.Append(words[index]);
                    index++;
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}