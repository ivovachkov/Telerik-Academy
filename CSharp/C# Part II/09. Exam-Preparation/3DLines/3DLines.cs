using System;

class ThreeDimensionLines
{
    static void Main()
    {

    }

    static bool IsInRange(int[,,]cube, int row, int col, int depth)
    {
        return (row >= 0) && (row < cube.GetLength(0)) &&
            (col >= 0) && (col < cube.GetLength(1)) &&
            (depth >= 0) && (depth < cube.GetLength(2));
    }
}