using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        Encoding encoding = Encoding.GetEncoding("utf-8");
        string path = "..\\..\\test.txt";
        StreamReader reader = new StreamReader(path, encoding);
        
        StringBuilder result = new StringBuilder();

        int counter = 1;
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (counter % 2 == 0)
            {
                result.Append(line + Environment.NewLine);
            }
            counter++;
        }
        reader.Close();
        result.Remove(result.Length -1, 1);

        StreamWriter writer = new StreamWriter(path, false, encoding);
        writer.Write(result.ToString());
        writer.Close();
    }
}