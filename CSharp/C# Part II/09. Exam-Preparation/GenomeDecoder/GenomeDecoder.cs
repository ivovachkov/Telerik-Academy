using System;
using System.Text;
using System.Collections.Generic;

class GenomeDecoder
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string code = Console.ReadLine();
        string[] input = firstLine.Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        StringBuilder b = new StringBuilder();
        Stack<int> num = new Stack<int>();

        for (int i = 0; i < code.Length; i++)
        {
            if (char.IsDigit(code[i]))
            {
                num.Push(code[i] - '0');
            }
            else
            {
                int count = 0;
                int stackSize = num.Count;

                if (stackSize == 0)
                {
                    count = 1;
                }

                for (int j = 0; j < stackSize; j++)
                {
                    count += num.Pop() * (int)Math.Pow(10, j);
                }

                while (count > 0)
                {
                    b.Append(code[i]);
                    count--;
                }
            }
        }

        int length = b.Length;
        int rows = length / n + (length % n == 0 ? 0 : 1);
        int first = n / m;
        int second = n % m;
        int pad = rows.ToString().Length + 1;
        int index = 0;        

        for (int i = 1; i <= rows; i++)
        {
            StringBuilder line = new StringBuilder();
            line.Append((i + " ").PadLeft(pad, ' '));
            for (int k = 1; k <= first; k++)
            {
                for (int j = 0; index < b.Length && j < m; j++)
                {
                    line.Append(b[index]);
                    index++;
                }
                if ((k != first || second != 0) && index < b.Length)
                {
                    line.Append(" ");
                }
            }

            for (int p = 0; p < second && index < b.Length; p++)
            {
                line.Append(b[index]);
                index++;
            }
            Console.WriteLine(line.ToString());
        }
    }
}