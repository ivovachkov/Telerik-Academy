using System;
using System.IO;
using System.Text;

class LineNumbersInsert
{
    static void Main()
    {
        var encoding = Encoding.GetEncoding("utf-8");
        var reader = new StreamReader("..\\..\\input.txt");
        var writer = new StreamWriter("..\\..\\output.txt");

        using (reader)
        {
            using (writer)
            {
                int lineNumber = 1;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    writer.WriteLine(string.Format("{0}. {1}", lineNumber, line));
                    lineNumber++;
                }
            }
        }

    }
}