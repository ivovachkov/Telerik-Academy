using System;
using System.IO;
using System.Text;

class ConcatenationOfFiles
{
    static void Main()
    {
        var encoding = Encoding.GetEncoding("utf-8");
        StreamReader reader = new StreamReader("..\\..\\first.txt", encoding);
        StreamWriter writer = new StreamWriter("..\\..\\result.txt", true, encoding);

        string text = reader.ReadToEnd();
        writer.Write(text);

        reader = new StreamReader("..\\..\\second.txt", encoding);

        text = reader.ReadToEnd();
        writer.Write(text);

        writer.Close();
        reader.Close();
    }
}