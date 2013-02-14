using System;

class Program
{
    static int n = int.Parse(Console.ReadLine());

    static void Main()
    {
        string a = "/ / / / / / / / / / / / / / / / / / / / / / / / / ";
        string b = " \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ ";
        string c = "\\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ ";
        string d = " / / / / / / / / / / / / / / / / / / / / / / / / / /";

        if (n % 4 == 0)
        {
            int iter = 1;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.Write("{0}{1}", new string('.', i), a.Substring(0, n / 2 - i));
                if (iter % 2 == 0)
                {
                    Console.Write("{0}{1}", b.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                else
                {
                    Console.Write("{0}{1}", c.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                Console.WriteLine();
            }

            iter = 1;
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write("{0}{1}", new string('.', i), c.Substring(0, n / 2 - i));
                if (iter % 2 == 0)
                {
                    Console.Write("{0}{1}", a.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                else
                {
                    Console.Write("{0}{1}", d.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            int iter = 1;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.Write("{0}{1}", new string('.', i), a.Substring(0, n / 2 - i));
                if (iter % 2 == 0)
                {
                    Console.Write("{0}{1}", b.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                else
                {
                    Console.Write("{0}{1}", c.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                Console.WriteLine();
            }

            iter = 1;
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write("{0}{1}", new string('.', i), c.Substring(0, n / 2 - i));
                if (iter % 2 == 0)
                {
                    Console.Write("{0}{1}", d.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                else
                {
                    Console.Write("{0}{1}", a.Substring(0, n / 2 - i), new string('.', i));
                    iter++;
                }
                Console.WriteLine();
            }
        }
    }
}