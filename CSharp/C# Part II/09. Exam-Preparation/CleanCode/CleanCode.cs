using System;
using System.Text;

class CleanCode
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isClosed = true;
        string com = "//";
        string open = "/*";
        string close = "*/";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();

            int len = line.Length;
            int comIndex = line.IndexOf(com, 0);
            int openIndex = line.IndexOf(open, 0);
            int closeIndex = line.LastIndexOf(close, len - 1);

            if (comIndex != -1)
            {
                result.Append(line.Substring(0, comIndex));
            }
            else if (openIndex != -1)
            {
                result.Append(line.Substring(0, openIndex));

                if (closeIndex != -1)
                {
                    result.Append(line.Substring(closeIndex + 2, len - closeIndex - 2));
                }
                else
                {
                    isClosed = false;
                }
            }
            else
            {
                if (closeIndex != -1)
                {
                    result.Append(line.Substring(0, closeIndex));
                }
                else if (isClosed)
                {
                    result.Append(line);
                }
            }
            result.Append('\n');
        }
        Console.WriteLine(result.ToString());
    }
}