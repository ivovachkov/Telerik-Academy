using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class WordOccurencesReplace
{
    static void Main()
    {
        Encoding encoding = Encoding.GetEncoding("utf-8");
        string inputPath = "..\\..\\input.txt";
        string resultPath = "..\\..\\result.txt";
        StreamReader reader = new StreamReader(inputPath, encoding);
        StreamWriter writer = new StreamWriter(resultPath, false, encoding);

        using (reader)
        {
            using (writer)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    writer.WriteLine(Regex.Replace(line, "\\bstart\\b", "finish"));
                }
            }
        }
    }
}