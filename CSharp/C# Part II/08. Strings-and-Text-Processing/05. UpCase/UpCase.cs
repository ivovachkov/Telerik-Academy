using System;
using System.Text;

class UpCase
{
    static void Main()
    {
        string text = "<upcase>We</upcase> are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> <upcase>else.</upcase>";
        StringBuilder result = new StringBuilder();
        int startIndex = text.IndexOf("<upcase>", 0);
        if (startIndex == -1)
        {
            result.Append(text);
        }
        else
        {
            result.Append(text.Substring(0, startIndex));
            int endIndex = text.IndexOf("</upcase>", startIndex + 8);
            while (true)
            {                  
                result.Append(text.Substring(startIndex + 8, endIndex - (startIndex + 8)).ToUpper());

                startIndex = text.IndexOf("<upcase>", endIndex + 9);

                if (startIndex != -1)
                {
                    result.Append(text.Substring(endIndex + 9, startIndex - (endIndex + 9)));
                    endIndex = text.IndexOf("</upcase>", startIndex + 8);
                }
                else
                {
                    break;
                }
            }
            result.Append(text.Substring(endIndex + 9));
        }
        Console.WriteLine(result.ToString());
    }
}