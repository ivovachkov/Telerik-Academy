using System;
using System.IO;
using System.Text;

class SubstringOccurencesReplace
{
    static void Main()
    {
        Encoding encoding = Encoding.GetEncoding("utf-8");
        string inputPath = "..\\..\\input.txt";
        string resultPath = "..\\..\\result.txt";
        StreamReader reader = new StreamReader(inputPath, encoding);
        StreamWriter writer = new StreamWriter(resultPath, false, encoding);
        string find = "start";
        string replace = "finish";
        StringBuilder line = new StringBuilder();

        using (reader)
        {
            using (writer)
            {
                while (!reader.EndOfStream)
                {
                    line.Append(reader.ReadLine());
                    writer.WriteLine(line.Replace(find, replace));
                    line.Clear();
                }
            }
        }
    }
}