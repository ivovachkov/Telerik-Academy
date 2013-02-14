using System;
using System.Collections.Generic;

class Stars3D
{
    static int width;
    static int height;
    static int depth;
    static char[, ,] cube;

    static void Main()
    {
        string line = Console.ReadLine();
        string[] tokens = line.Split();
        width = int.Parse(tokens[0]);
        height = int.Parse(tokens[1]);
        depth = int.Parse(tokens[2]);
        cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = (char)Console.Read();
                }
                Console.Read();
            }
            Console.Read();
        }

        List<char> result = new List<char>();
        for (int w = 1; w < width - 1; w++)
        {
            for (int h = 1; h < height - 1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    if (cube[w, h, d] == cube[w + 1, h, d] &&
                        cube[w, h, d] == cube[w - 1, h, d] &&
                        cube[w, h, d] == cube[w, h + 1, d] &&
                        cube[w, h, d] == cube[w, h - 1, d] &&
                        cube[w, h, d] == cube[w, h, d + 1] &&
                        cube[w, h, d] == cube[w, h, d - 1])
                    {
                        result.Add(cube[w, h, d]);
                    }
                }
            }
        }
        Console.WriteLine(result.Count);

        result.Sort();
        int letterCount = 1;
        
        for (int i = 0; i < result.Count - 1; i++)
        {
            if (result[i] == result[i + 1])
            {
                letterCount++;
            }
            else
            {
                Console.WriteLine("{0} {1}", result[i], letterCount);
                letterCount = 1;
            }
        }

        if (result.Count > 0)
        {
            Console.WriteLine("{0} {1}", result[result.Count - 1], letterCount);
        }        
    }
}