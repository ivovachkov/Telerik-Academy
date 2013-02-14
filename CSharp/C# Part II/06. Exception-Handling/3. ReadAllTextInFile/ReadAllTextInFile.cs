using System;
using System.IO;
using System.Text;

class ReadAllTextInFile
{
    static void Main()
    {
        string filePath = "..\\..\\test.txt";
        try
        {
            string text = File.ReadAllText(filePath, Encoding.GetEncoding("utf-8"));
            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file cannot be found int the path shown!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory you've shown could not be found");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path you've shown is too long");
        }
        catch (IOException)
        {
            Console.WriteLine("The device you've shown cannot be found or the file is used by another program");
        }
        catch (ArgumentNullException ae)
        {
            Console.WriteLine(ae.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye:)");
        }
    }
}