using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class PrefixDeleting
{
    static void Main()
    {
        ////Solution With Regular Expressions
        //StreamReader reader = new StreamReader("..\\..\\input.txt", Encoding.UTF8);
        //StreamWriter writer = new StreamWriter("..\\..\\temp.txt", false, Encoding.UTF8);

        //using (reader)
        //using (writer)
        //{
        //    string text = reader.ReadToEnd();
        //    text = Regex.Replace(text, "\\btest", "");
        //    writer.Write(text);
        //}
        //File.Copy("..\\..\\temp.txt", "..\\..\\input.txt", true);
        //File.Delete("..\\..\\temp.txt");

        // Without regex
        DeletePrefix("..\\..\\input.txt", "test");
    }

    static void DeletePrefix(string path, string wordToDelete)
    {
        StreamReader reader = new StreamReader(path, Encoding.UTF8);
        StreamWriter writer = new StreamWriter("..\\..\\temp.txt", false, Encoding.UTF8);

        using (reader)
        using (writer)
        {
            string line = reader.ReadLine();            
            while (!reader.EndOfStream)
            {
                int index = line.IndexOf(wordToDelete, 0);
                while (index != -1)
                {
                    if (char.IsLetterOrDigit(line[index + wordToDelete.Length]) 
                        && (index == 0 || line[index - 1] == ' '))
                    {
                        line = line.Remove(index, wordToDelete.Length);
                    }
                    index = line.IndexOf(wordToDelete, index + 1);
                }
                writer.WriteLine(line);
                line = reader.ReadLine();
            }
        }
        File.Copy("..\\..\\temp.txt", path, true);
        File.Delete("..\\..\\temp.txt");
    }
}