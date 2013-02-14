using System;

class AnchorTagReplace
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string result = text.Replace("<a href=\"", "[URL=");
        result = result.Replace("\">", "]");
        result = result.Replace("</a>", "[/URL]");
        Console.WriteLine(result);
    }
}