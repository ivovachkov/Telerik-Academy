using System;

class ThreeDimensionMaxWalk
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] tokens = line.Split();
        int width = int.Parse(tokens[0]);
        int height = int.Parse(tokens[1]);
        int depth = int.Parse(tokens[2]);
        int[, ,] cube = new int[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            line = Console.ReadLine();
            tokens = line.Split('|');
            for (int d = 0; d < depth; d++)
            {
                string[] rows = tokens[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = int.Parse(rows[w]);
                }
            }
        }

        int[] widthDir = { 1, -1, 0, 0, 0, 0 };
        int[] heightDir = { 0, 0, 1, -1, 0, 0 };
        int[] depthDir = { 0, 0, 0, 0, 1, -1 };

        int sw = width / 2;
        int sh = height / 2;
        int sd = depth / 2;
        int sum = cube[sw, sh, sd];
        
        bool[, ,] visited = new bool[width, height, depth];
        visited[sw, sh, sd] = true;

        int nextW = sw;
        int nextH = sh;
        int nextD = sd;

        

        //while ()
        {
            sw = nextW;
            sh = nextH;
            sd = nextD;
            int max = int.MinValue;

            for (int i = 0; i < 6; i++)
            {
                while (true)
                {
                    sw += widthDir[i];
                    sh += heightDir[i];
                    sd += depthDir[i];

                    if (IsInRange(cube, sw, sh, sd) && !visited[sw, sh, sd])
                    {

                        if (max <= cube[sw, sh, sd])
                        {
                            max = cube[sw, sh, sd];
                            nextW = sw;
                            nextH = sh;
                            nextD = sd;
                        }
                        visited[sw, sh, sd] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            sum += max;
        }
        Console.WriteLine(sum);
    }

    static bool IsInRange(int[, ,] cube, int width, int height, int depth)
    {
        return width < cube.GetLength(0) && width >= 0 &&
            height < cube.GetLength(1) && height >= 0 &&
            depth < cube.GetLength(2) && depth >= 0;
    }
}