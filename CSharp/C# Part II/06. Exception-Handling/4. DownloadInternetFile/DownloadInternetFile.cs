using System;
using System.Net;

class DownloadInternetFile
{
    static void Main()
    {
        WebClient downloader = new WebClient();
        try
        {
            downloader.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "..\\..\\logo.png");
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (WebException we)
        {
            Console.WriteLine("Invalid URL!");
            Console.WriteLine(we.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (downloader != null)
            {
                downloader.Dispose();
            }
        }
        
    }
}