using System;
using System.IO;
using System.Text;

class HTMLParse
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\index.html", Encoding.GetEncoding("windows-1251"));
        StreamWriter writer = new StreamWriter("..\\..\\output.txt", false, Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            using (writer)
            {
                string text = reader.ReadToEnd();
                int index = text.IndexOf('>', 0);
                int secondIndex = text.IndexOf('<', index + 1);
                while (secondIndex != -1)
                {
                    string content = text.Substring(index + 1, secondIndex - index - 1);
                    content = content.Trim() + " ";
                    writer.Write(content);
                    index = text.IndexOf('>', secondIndex + 1);
                    secondIndex = text.IndexOf('<', index + 1);
                }
            }
        }
    }
}