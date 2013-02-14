using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        string file = "..\\..\\test.txt";
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("utf-8"));
        using (reader)
        {
            int lineNumber = 1;            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                lineNumber ++;
            }
        }
    }
}