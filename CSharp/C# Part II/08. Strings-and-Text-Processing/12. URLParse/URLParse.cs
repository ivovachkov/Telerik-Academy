using System;

class URLParse
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php ";

        string protocol = url.Substring(0, url.IndexOf(':', 0));
        int pLen = protocol.Length;
        string server = url.Substring(pLen + 3, url.IndexOf("/", pLen + 3) - (pLen + 3));
        int sLen = server.Length;
        string resource = url.Substring(url.IndexOf(server, 0) + sLen);

        Console.WriteLine("[protocol]: {0}\n[server]: {1}\n[resource]: {2}", protocol, server, resource);
    }
}