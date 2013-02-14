using System;
using System.IO;
using System.Text;

class SortingListOfNames
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
            string input = reader.ReadToEnd();
            string[] list = input.Split(new char[]{' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(list);

            using (writer)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }
    }
}