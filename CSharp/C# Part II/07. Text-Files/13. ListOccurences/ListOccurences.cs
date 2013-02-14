using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;


class ListOccurences
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("..\\..\\words.txt");
            StreamReader reader = new StreamReader("..\\..\\test.txt");
            StreamWriter writer = new StreamWriter("..\\..\\result.txt");
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                occurences.Add(words[i], 0);
            }

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
                            foreach (var item in words)
                            {
                                if (string.Compare(item, word.ToString(), true) == 0)
                                {
                                    occurences[item]++;
                                }
                            }
                            word.Clear();
                        }
                    }
                }
                var ordered = occurences.OrderByDescending(x => x.Value);
                foreach (var item in ordered)
                {
                    writer.WriteLine("{0} - {1}", item.Key, item.Value);
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