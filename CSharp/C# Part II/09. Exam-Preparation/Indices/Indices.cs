using System;
using System.Text;

class Indices
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        string[] tokens = line.Split();
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(tokens[i]);
        }

        int index = 0;
        bool[] visited = new bool[length];

        StringBuilder result = new StringBuilder();

        while (index < length && index >= 0)
        {
            if (visited[index])
            {
                if (index == 0)
                {
                    result.Insert(0, '(');
                }
                else
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == index.ToString()[0])
                        {
                            result.Replace(' ', '(', i - 1, 1);
                            break;
                        }
                    }
                }
                result.Insert(result.Length - 1, ')');
                break;
            }
            else
            {
                visited[index] = true;
                result.Append(index + " ");
                index = numbers[index];
            }
        }
        Console.WriteLine(result.ToString().Trim());
    }
}