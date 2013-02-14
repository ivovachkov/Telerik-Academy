using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class DictionaryRelease
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\dictionary.txt", Encoding.UTF8);
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        using (reader)
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] components = line.Split('-');
                dictionary.Add(components[0].Trim(), components[1].Trim());
            }
        }
        string input = ".NET";

        Console.WriteLine(input + " - " +dictionary[input]);
    }
}