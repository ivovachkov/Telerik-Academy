using System;
using System.IO;
using System.Text;

class FileComparison
{
    static void Main()
    {
        var encoding = Encoding.GetEncoding("utf-8");
        string firstFile = "..\\..\\first.txt";
        string secondFile = "..\\..\\second.txt";
        var firstReader = new StreamReader(firstFile, encoding);
        var secondReader = new StreamReader(secondFile, encoding);

        using (firstReader)
        {
            using (secondReader)
            {
                int lineNumber = 1;
                while (!firstReader.EndOfStream)
                {                    
                    string first = firstReader.ReadLine();
                    string second = secondReader.ReadLine();
                    if (first == second)
                    {
                        Console.Write("Equal: ");
                        Console.WriteLine(lineNumber);
                    }
                    else
                    {
                        Console.Write("Not Equal: ");
                        Console.WriteLine(lineNumber);
                    }
                    lineNumber++;
                }
            }
        }
	}
}