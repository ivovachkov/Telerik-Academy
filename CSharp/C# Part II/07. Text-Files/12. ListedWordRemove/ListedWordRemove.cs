using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class ListedWordRemove
{
    static void Main()
    {
        try
        {
            string[] list = File.ReadAllLines("..\\..\\list.txt");
            var reader = new StreamReader("..\\..\\input.txt");
            var writer = new StreamWriter("..\\..\\result.txt");
            using (reader)
            using (writer)
            {
                while (!reader.EndOfStream)
                {
                    StringBuilder line = new StringBuilder(reader.ReadLine());
                    StringBuilder word = new StringBuilder();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsLetter(line[i]))
                        {
                            word.Append(line[i]);
                        }
                        else
                        {
                            foreach (var item in list)
                            {
                                if (string.Compare(item, word.ToString(), true) == 0)
                                {
                                    line.Remove(i - word.Length, word.Length);
                                    i = i - word.Length;
                                }
                            }
                            word.Clear();
                        }
                    }
                    writer.WriteLine(line.ToString());
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}